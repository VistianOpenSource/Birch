using System;
using System.Collections.Generic;
using Birch.Reflection;

namespace Birch.Hosts
{
    /// <summary>
    /// Class used for the setup of environment.
    /// </summary>
    /// <remarks>
    /// Each <see cref="IEnvironmentBuilderComponent{TSettings}"/> settings is held within
    /// a dictionary and when the environment is created, an instance of each environment
    /// builder component is spun up and the settings applied.
    /// </remarks>
    public class EnvironmentBuilder
    {
        /// <summary>
        /// Base implementation 
        /// </summary>
        private interface IEnvironmentSetting
        {
            void Apply();
        }

        private interface IEnvironmentSetting<TSetting>:IEnvironmentSetting
        {
            TSetting Settings { get; set; }
        }

        private class ActionSettings<TSetting>:IEnvironmentSetting<TSetting>
        {
            private readonly Action<TSetting> _action;

            public ActionSettings(Action<TSetting> action)
            {
                this._action = action;
            }

            public void Apply()
            {
                _action(Settings);
            }

            public TSetting Settings { get; set; }
        }

        /// <summary>
        /// Internal class used to setup the environment
        /// </summary>
        /// <typeparam name="THost"></typeparam>
        /// <typeparam name="TSetting"></typeparam>
        private class HostEnvironmentSetting<THost,TSetting> : IEnvironmentSetting<TSetting> where THost:IEnvironmentBuilderComponent<TSetting> , new()
        {
            public void Apply()
            {
                var instance = new THost();

                instance.Apply(Settings);
            }

            public TSetting Settings { get; set; }
        }

        /// <summary>
        /// Dictionary of <see cref="IEnvironmentSetting"/>, indexed by <see cref="IEnvironmentBuilderComponent{TSettings}"/>
        /// </summary>
        private readonly Dictionary<Type,IEnvironmentSetting> _settings = new Dictionary<Type, IEnvironmentSetting>();

        /// <summary>
        /// Environment settings where an action is being used to apply the settings.
        /// </summary>
        /// <typeparam name="TSettings"></typeparam>
        /// <param name="action"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public EnvironmentBuilder With<TSettings>(Action<TSettings> action,TSettings settings) 
        {
            var hs = new ActionSettings<TSettings>(action) {Settings = settings};

            _settings[typeof(IEnvironmentBuilderComponent<TSettings>)] = hs;

            return this;
        }

        /// <summary>
        /// Specify the settings for a particular <see cref="IEnvironmentBuilderComponent{TSettings}"/>
        /// </summary>
        /// <typeparam name="THost"></typeparam>
        /// <typeparam name="TSettings"></typeparam>
        /// <param name="settings"></param>
        /// <returns></returns>
        public EnvironmentBuilder With<THost,TSettings>(TSettings settings) where THost:IEnvironmentBuilderComponent<TSettings>, new()
        {
            var hs = new HostEnvironmentSetting<THost, TSettings> {Settings = settings};

            _settings[typeof(IEnvironmentBuilderComponent<TSettings>)] = hs;

            return this;
        }

        /// <summary>
        /// Get the settings for a specified type.
        /// </summary>
        /// <typeparam name="TSettings"></typeparam>
        /// <returns></returns>
        public TSettings Get<TSettings>() 
        {
            var settings = _settings[typeof(IEnvironmentBuilderComponent<TSettings>)];

            return ((IEnvironmentSetting<TSettings>) settings).Settings;
        }

        /// <summary>
        /// Create a valid environment...hopefully.
        /// </summary>
        public void Create()
        {
            foreach (var item in _settings.Values)
            {
                try
                {
                    item.Apply();
                }
                catch (Exception exception)
                {
                    throw new InvalidOperationException($"Unable to setup environment. Failed with {item.GetType().FriendlyName()}",exception);
                }
            }
        }
    }
}