using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Diagnostics;
using Birch.Hosts;
using Microsoft.Extensions.Logging;
using Logging = Birch.Diagnostics.Logging;

namespace Birch.XamarinForms.Hosts
{
    /// <summary>
    /// Default Xamarin Forms <see cref="IBuildErrorPolicy"/> implementation.
    /// </summary>
    public class DefaultErrorPolicy:BuildErrorPolicy<XamFormsBuildHostInstance>
    {

        protected override IElement LayoutErrorFormat(XamFormsBuildHostInstance buildHostInstance, Exception exception)
        {
            Logging.Instance.LogError(exception,"Recoverable Error during layout");
     
            throw new NotImplementedException();


            //var exceptions = GetInnerExceptions(exception).Select(e => Xa(e.Message)).ToList();

            //exceptions.AddRange(GetInnerExceptions(exception).Select(e => TextView(e.StackTrace)));

            //return new Activity(buildHostInstance.Activity, LinearLayout(exceptions).Orientation(Android.Widget.Orientation.Vertical));
        }

        protected override void FatalError(XamFormsBuildHostInstance buildHostInstance, Exception exception)
        {
            Logging.Instance.LogError(exception,"Error during layout");

            throw exception;
        }
    }
}
