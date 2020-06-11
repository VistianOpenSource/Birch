using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Diagnostics;
using Birch.Hosts;
using Birch.Reflection;
using Birch.Views;
using Microsoft.Extensions.Logging;
using Xamarin.Forms;
using static Birch.Views.Primitives;


namespace Birch.XamarinForms.Hosts
{
    /// <summary>
    /// Default Xamarin Forms <see cref="IBuildErrorPolicy"/> implementation.
    /// </summary>
    public class DefaultErrorPolicy : BuildErrorPolicy<XamFormsBuildHostInstance>
    {
        public override IElement LayoutErrorFormat(XamFormsBuildHostInstance buildHostInstance, Exception exception)
        {
            var list = ListView(new IReflectedPrimitive<Cell>[]{ViewCell(
                Label(exception.ToString()).LineBreakMode(LineBreakMode.CharacterWrap))}).
                HasUnevenRows(true);

            var resetButton = Button("Reset").OnClicked(() =>
            {
                buildHostInstance.Reset();
                buildHostInstance.Start();
            });

            var stackLayout = StackLayout(new IPrimitive[] {list,resetButton}).Orientation(StackOrientation.Vertical);

            return ContentPage(buildHostInstance.ContentPage,stackLayout);
        }
    }

}
