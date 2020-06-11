using System;
using System.Linq;
using Birch.Components;
using Birch.Diagnostics;
using Birch.Views;
using Microsoft.Extensions.Logging;
using static Birch.Views.Primitives;

namespace Birch.Hosts
{
    /// <summary>
    /// Default Android <see cref="IBuildErrorPolicy"/> implementation.
    /// </summary>
    public class DefaultErrorPolicy:BuildErrorPolicy<AndroidBuildHostInstance>
    {
        public override IElement LayoutErrorFormat(AndroidBuildHostInstance buildHostInstance, Exception exception)
        {
            var exceptions = exception.GetInnerExceptions().Select(e => TextView(e.Message)).ToList();

            exceptions.AddRange(exception.GetInnerExceptions().Select(e => TextView(e.StackTrace)));

            return new Activity(buildHostInstance.Activity, LinearLayout(exceptions).Orientation(Android.Widget.Orientation.Vertical));
        }
    }
}