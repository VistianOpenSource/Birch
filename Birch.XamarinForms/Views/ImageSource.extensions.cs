using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Birch.Components;
using Birch.Reflection;
using Birch.Shadows;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Birch.Views
{
    public static class ImageSourceExtensions
    {
        public static Attribute<string> ImageFromUriAttribute = Components.Attribute.Register<string>(Components.Attribute.Name<Xamarin.Forms.VisualElement>(nameof(ImageFromUriAttribute)));

        public static Attribute<ResourceDescriptor> ImageFromResourceAttribute = Components.Attribute.Register<ResourceDescriptor>(Components.Attribute.Name<Xamarin.Forms.VisualElement>(nameof(ImageFromResourceAttribute)));

        public static Attribute<string> ImageFromFileAttribute = Components.Attribute.Register<string>(Components.Attribute.Name<Xamarin.Forms.VisualElement>(nameof(ImageFromFileAttribute)));

        static ImageSourceExtensions()
        {
            // need to setup the automatic mappings...
            // this is a bit difficult since, we don't have a standard image source element

            // Button has it - ImageSource
            // Image has it - Source
            // ToolbarItem - IconImageSource
            // ImageButton - Source property
            // ImageCell - ImageSource
            // Page  - IconImageSource, or BackgroundImageSource

            // do we need to create some 'standard' mapper in which a generic simple function is applied?

            //ImageSource.FromR

            AttributeMapperStore.Default.Register(ImageFromUriAttribute,ImageFromUriAttribute.Mapper<string,Xamarin.Forms.Element>((s, u) =>
                {
                    var action = GetSetAction(s);
                    var imageSource = ImageSource.FromUri(new Uri(u));
                    action(s, imageSource);
                }, (s, c, n) =>
                {
                    var action = GetSetAction(s);
                    var imageSource = ImageSource.FromUri(new Uri(n));
                    action(s, imageSource);
                },
                (s, c) =>
                {
                    var action = GetSetAction(s);
                    action(s, null);
                }));

            AttributeMapperStore.Default.Register(ImageFromResourceAttribute,ImageFromResourceAttribute.Mapper<ResourceDescriptor,Xamarin.Forms.Element>((s, u) =>
                {
                    var action = GetSetAction(s);

                    var imageSource = u.Assembly != null ? ImageSource.FromResource(u.Resource,u.Assembly) : ImageSource.FromResource(u.Resource,u.Type);

                    action(s, imageSource);

                }, (s, c, n) =>
                {
                    var action = GetSetAction(s);
                    var imageSource = n.Assembly != null ? ImageSource.FromResource(n.Resource,n.Assembly) : ImageSource.FromResource(n.Resource,n.Type);
                    action(s, imageSource);
                },
                (s, c) =>
                {
                    var action = GetSetAction(s);
                    action(s, null);
                }));


            AttributeMapperStore.Default.Register(ImageFromFileAttribute,ImageFromFileAttribute.Mapper<string,Xamarin.Forms.Element>((s, u) =>
                {
                    var action = GetSetAction(s);

                    var imageSource = ImageSource.FromFile(u);

                    action(s, imageSource);

                }, (s, c, n) =>
                {
                    var action = GetSetAction(s);
                    var imageSource = ImageSource.FromFile(n);
                    action(s, imageSource);
                },
                (s, c) =>
                {
                    var action = GetSetAction(s);
                    action(s, null);
                }));




        }

        private static Action<IShadow, ImageSource> GetSetAction(IShadow<Xamarin.Forms.Element> shadow)
        {
            return shadow.Item switch
            {
                Xamarin.Forms.Button _ => ImageSourceMappers.Button,
                Xamarin.Forms.Image _ => ImageSourceMappers.Image,
                Xamarin.Forms.ToolbarItem _ => ImageSourceMappers.ToolbarItem,
                Xamarin.Forms.ImageButton _ => ImageSourceMappers.ImageButton,
                Xamarin.Forms.ImageCell _ => ImageSourceMappers.ImageCell,
                _ => throw new ArgumentException()
            };

            ;
        }

        public static IReflectedPrimitive<Xamarin.Forms.Button> ImageFromUri(this IReflectedPrimitive<Xamarin.Forms.Button> control, string uri)
        {
            control.Attributes.SetAttribute(ImageFromUriAttribute, uri);
            return control;
        }

        public static IReflectedPrimitive<Xamarin.Forms.Image> ImageFromUri(IReflectedPrimitive<Xamarin.Forms.Image> control, string uri)
        {
            control.Attributes.SetAttribute(ImageFromUriAttribute, uri);
            // we need to set the attribute...
            return control;
        }


    }

    public class ResourceDescriptor:IEquatable<ResourceDescriptor>
    {
        public string Resource { get; private set; }

        public Type Type { get; private set; }

        public Assembly Assembly { get; private set; }

        public static ResourceDescriptor For(string resource, Type type) => new ResourceDescriptor() {Resource = resource, Type = type};

        public static ResourceDescriptor For(string resource, Assembly assembly) => new ResourceDescriptor()
            {Resource = resource, Assembly = assembly};

        public bool Equals(ResourceDescriptor other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Resource == other.Resource && Type == other.Type && (Assembly?.FullName == other.Assembly?.FullName);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ResourceDescriptor) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Resource, Type, Assembly);
        }

        public static bool operator ==(ResourceDescriptor left, ResourceDescriptor right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ResourceDescriptor left, ResourceDescriptor right)
        {
            return !Equals(left, right);
        }
    }



    public static class ImageSourceMappers
    {
        public static Action<IShadow, ImageSource> Button = (s, i) => ((IShadow<Xamarin.Forms.Button>) s).Item.ImageSource = i;

        public static Action<IShadow, ImageSource> Image = (s, i) => ((IShadow<Xamarin.Forms.Image>) s).Item.Source = i;

        public static Action<IShadow, ImageSource> ToolbarItem = (s, i) => ((IShadow<Xamarin.Forms.ToolbarItem>) s).Item.IconImageSource = i;

        public static Action<IShadow, ImageSource> ImageButton = (s, i) => ((IShadow<Xamarin.Forms.ImageButton>) s).Item.Source = i;

        public static Action<IShadow, ImageSource> ImageCell = (s, i) => ((IShadow<Xamarin.Forms.ImageCell>) s).Item.ImageSource = i;

        public static Action<IShadow, ImageSource> PageIcon = (s, i) => ((IShadow<Xamarin.Forms.Page>) s).Item.IconImageSource = i;

        public static Action<IShadow, ImageSource> PageBackground = (s, i) => ((IShadow<Xamarin.Forms.Page>) s).Item.BackgroundImageSource = i;
    }

}
