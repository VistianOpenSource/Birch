using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Android.Accounts;
using Android.App;
using Android.Content;
using Android.Database.Sqlite;
using Android.Graphics;
using Android.Hardware.Camera2;
using Android.Icu.Text;
using Android.Media;
using Android.Net.Sip;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Support.Annotation;
using Android.Support.Design.Animation;
using Android.Support.Design.Widget;
using Android.Support.Transitions;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Text;
using Android.Util;
using Android.Views;
using Android.Widget;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Diagnostics;
using Birch.Hosts;
using Birch.Metrics;
using Birch.Reflection;
using Birch.Shadows;
using Birch.Views;
using Microsoft.Extensions.Logging;
using MVU_Experiment.RV;
using Org.Apache.Http.Conn;
using static System.Linq.Enumerable;
using static Android.Widget.LinearLayout;
using ActionBar = Android.App.ActionBar;
using ContextThemeWrapper = Android.Support.V7.View.ContextThemeWrapper;
using Orientation = Android.Widget.Orientation;
using static Birch.Views.Primitives;
using Activity = Birch.Views.Activity;
using Logging = Birch.Diagnostics.Logging;


namespace MVU_Experiment
{
    public class AppStatefulContainer : StatefulContainer<int>
    {
        private readonly Android.App.Activity _activity;
        private readonly UserDetails _userDetails;

        public AppStatefulContainer(Android.App.Activity activity, BuildEnvironment environment) : base(environment)
        {
            _activity = activity;
            _userDetails = new UserDetails(environment);
        }

        public override int InitState()
        {
            return 0;
        }

        protected override IPrimitive PerformLayout(LayoutContext layoutContext, int model)
        {
            var activity = new Activity(_activity, _userDetails.Layout(layoutContext));

            return activity;
        }
    }

    public partial class IndividualUser : IComposite
    {
        private readonly int _userId;
        private readonly string _preAppend;

        public IndividualUser(int userId, string preAppend = default)
        {
            _userId = userId;
            _preAppend = preAppend;
        }

        private static Expression<Func<Android.Widget.TextView, string>> SetText = x => x.Text;

        public IPrimitive PerformLayout(LayoutContext context) =>
            TextView("User:" + (_preAppend ?? "") + (_userId) + " finally", Dimensions.WrapWrap).SetTypeface(Typeface.SansSerif,TypefaceStyle.Bold);

        /* With(p => nameof(p.Click), () =>
         {
             Console.WriteLine("***********************************I've been clicked");
         })*/
    }


    /*
    public class UserDetailsXLayoutProvider : ILayoutProvider<UserDetailsX>
    {
        public IPrimitiveComponent PerformLayout(UserDetailsX component)
        {
            var model = component.Context.Owner.GetState(component);


//            if ((model / 100) == 0)
            {
             //   GC.Collect();
            }

            var dp = new ShadowDependsUpon<int,IViewComponent2[]>(() => model,
                () =>
                {
                    return Enumerable.Range(0, 50).Select(i => new IndividualUser(i + model)).ToArray();
                }
            );


            //component.
//            var controls = Enumerable.Range(0, 50).Select(i => new IndividualUser(i + model,"separate ")).ToArray();
            try
            {
                IPrimitiveComponent topControl;
                topControl = new ShadowLinearLayout
                {
                    Children = dp, LayoutParamsFactory = (d) => new LayoutParams(d.Width, d.Height)
                }.With(t => t.Orientation,Orientation.Vertical);
                return topControl;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }*/


    public class StatefulIndividualUser : StatefulContainer<int>
    {
        private readonly int _baseIndex;
        private readonly UsernamePasswordWidget _userNamePassword;

        public StatefulIndividualUser(BuildEnvironment environment, int baseIndex) : base(environment)
        {
            _baseIndex = baseIndex;

            if (baseIndex < 1)
            {
                _userNamePassword = new UsernamePasswordWidget(environment);
            }
            else
            {
                if (baseIndex == 1)
                {
                    Observable.Interval(TimeSpan.FromMilliseconds(1000)).Do(t => { this.SetModel((int)(t % 1000)); })
                        .Subscribe();
                }
            }
        }

        public override int InitState() => 0;

        protected override IPrimitive PerformLayout(LayoutContext layoutContext, int model)
        {
            if (_baseIndex < 1)
            {
                return _userNamePassword.Layout(layoutContext);

                //tv.TextColors = Color.Red;
                //tv.SetTextColor(Color.Red);

                //var dp1 = new[]
                //{
                //    View<Android.Widget.TextView>(Dimensions.MatchMatch).Text($"User:{_baseIndex}:{model}")

                //};

                //var dp2 = new[]
                //{
                //    View<Android.Widget.TextView>(Dimensions.MatchMatch).Text($"User:{_baseIndex}:{model}"),
                //    View<Android.Widget.TextView>(Dimensions.MatchMatch).Text($"Added line !")

                //};

                // need to create a linear layout here
                //return new ShadowLinearLayout((model % 2) == 0 ? dp1 : dp2).
                //    //{Children = dp2}.
                //    Dimensions(Dimensions.WrapWrap).Orientation(Orientation.Vertical);
            }
            else
            {
                return TextView($"User:{_baseIndex}:{model}").Dimensions(Dimensions.WrapWrap);

                //return DependsOn((_baseIndex, model), ((int baseI,int mod) d) => 
                //        DependsOnCall(d.baseI,d.mod)
                //        )
                //    .Layout(layoutContext);
            }
        }

        private static IElement DependsOnCall(int baseIndex,int model) => TextView($"User:{baseIndex}:{model}").Dimensions(Dimensions.WrapWrap);
    }


    public class UsernamePasswordWidget : StatefulContainer<UsernamePasswordWidget.Model>
    {
        // our internal model
        public class Model
        {
            public string Name { get; set; }

            public bool IsNameValid => Name.Length >= 10;

            public string Password { get; set; }

            public Model()
            {
            }

            public Model(string name, string password)
            {
                Name = name;
                Password = password;
            }
        }

        private readonly Model _currentModel;

        public UsernamePasswordWidget(BuildEnvironment environment) : base(environment)
        {
            _currentModel = new Model("enter your username", "this is the password");
        }

        public override Model InitState() => _currentModel;

        protected override IPrimitive PerformLayout(LayoutContext layoutContext, Model model)
        {
            IEnumerable<IPrimitive> ItemsOdd()
            {
                yield return EditText(model.Name).
                    OnCreate((Shadow<EditText> s) => { s.Item.RequestFocus(); }).
                    //OnTextChanged((x) =>
                    //{
                    //    _currentModel.Name = x.Text.ToString();

                    //    this.SetState(_currentModel);

                    //}).
                    Event(x => nameof(x.TextChanged),(TextChangedEventArgs args) => _currentModel.Name = args.Text.ToString())
                    ;

                if (!model.IsNameValid)
                {
                    yield return TextView("Your input isn't valid", Dimensions.MatchMatch).SetTextColor(Color.Red).SetTextSize(ComplexUnitType.Dip, 24.0f);
                }

                yield return EditText(model.Password).InputType(InputTypes.ClassText | InputTypes.TextVariationPassword);

                yield return AnalogClock();

                yield return RadioGroup(new[] {RadioButton(id:1).Text("button1"), RadioButton(id:2).Text("button2")}).Check(model.IsNameValid ? 1 : 2);
            };

            IEnumerable<IPrimitive> ItemsEven()
            {
                yield return EditText(model.Name). //OnCreate((Shadow<EditText> s) => { s.Item.RequestFocus(); })
                    OnTextChanged(OnUsernameChanged);

                //yield return TextView("Text1", Dimensions.MatchMatch);

                yield return EditText(model.Password).InputType(InputTypes.ClassText | InputTypes.TextVariationPassword);
                ;
                if (!model.IsNameValid)
                {
                    yield return TextView("Your input isn't valid", Dimensions.MatchMatch).SetTextColor(Color.Red).SetTextSize(ComplexUnitType.Dip, 24.0f);
                }

                yield return AnalogClock();

                yield return RadioGroup(new[] {RadioButton(id:1).Text("button1"), RadioButton(id:2).Text("button2")}).Check(model.IsNameValid ? 1 : 2);
            };

            return LinearLayout(ItemsOdd(),Dimensions.MatchWrap).Orientation(Orientation.Vertical).Comparer(MyerComparer<IPrimitive>.Default);
        }

        private void OnUsernameChanged(TextChangedEventArgs args)
        {
            // now, how do we send a message with all of the current values in it ?
            _currentModel.Name = args.Text.ToString();

            this.SetModel(_currentModel);
        }
    }

    public class UserDetails : StatefulContainer<int>
    {
        private readonly BuildEnvironment _environment;

        public UserDetails(BuildEnvironment environment) : base(environment)
        {
            RecyclerView rv = null;

            //rv.GetAdapter())
            _environment = environment;

            _obs = Observable.Interval(TimeSpan.FromMilliseconds(100)).//Do(i => Console.WriteLine($"Adding User {i}")).
                TakeWhile(i => i < 50).
                Select(t => new StatefulIndividualUser(environment, (int) t));

            //var dis = Observable.Interval(TimeSpan.FromSeconds(1)).
            //    Do(i => Console.WriteLine($"Adding User {i}")).
            //Do(i =>
            //        { this.SetState((int)i); }).
            //TakeWhile(i => i < 100).
            //    Select(t => new StatefulIndividualUser(context, (int)t)).
            //    Do(r => _generated.Add(r)).
            //Subscribe();

            _layoutManager1 = new LinearLayoutManager(Application.Context) {Orientation = (int) Orientation.Vertical};

            //_obs = Observable.Interval(TimeSpan.FromSeconds(1)).Do(i => Console.WriteLine($"Adding User {i}"))
            //    .TakeWhile(i => i < 5).Select(t => new StatefulIndividualUser(context, (int) t));

            //_persistentList = new ObservableGroupFacade<ShadowRecyclerView,RecyclerView>(context,
            //    Observable.Interval(TimeSpan.FromSeconds(1)).Do(i => Console.WriteLine($"Adding User {i}"))
            //        .TakeWhile(i => i < 100).Select(t => new StatefulIndividualUser(context, (int) t)));

//            _persistentList.Connect();
        }

        public override int InitState() => 0;

        private ViewRef<Android.Widget.TextView> _viewRef = new ViewRef<Android.Widget.TextView>();

        private static Expression<Func<Android.Widget.TextView, string>> exp = (r) => r.Text;
        private IObservable<IElement> _obs;

        private LinearLayoutManager _layoutManager1;

        protected override IPrimitive PerformLayout(LayoutContext context, int model)
        {
            if (Birch.Components.Primitives.NeverInclude)
            {
                RecyclerView rv = null;
                rv.SetLayoutManager(_layoutManager1);
                rv.HasFixedSize = true;
            }

            var srv = new ShadowRecyclerView().LayoutManager(_layoutManager1).With((x) => x.HasFixedSize, false).Comparer(MyerComparer<IPrimitive>.Default);

            return Collection.From( _environment,
                _obs,
                srv
            ).Layout(context);

            //return _persistentList.Clear().With(p=> p.Alpha,0.5f).Layout(context);

            //return ShadowRecyclerViewFacade.From(_generated).Layout(context);

            //return ShadowRecyclerViewFacade.From(_obs).Layout(context);//.Dimensions(Dimensions.MatchMatch);

            //return AndroidViewGroupFacade<ShadowRecyclerView, RecyclerView, View>.From(_obs).Layout(context);

            var dp = Range(0, 50).Select(i => new IndividualUser(i + model));


            //var rf = new ReflectedComponent<EditText>();
            //rf.Set(b => b.Text, model).Event(b => nameof(b.Click), 
            //    () =>
            //{
            //    Console.WriteLine("I've been clicked");
            //});


            /*

            var listener = new Listener();

            et.AddOnAttachStateChangeListener(listener);
            et.RemoveOnAttachStateChangeListener(listener);
            */


            //return rf;

            //var tv = new ShadowEditTextElement();
            //tv.SetAttribute(ShadowEditTextElement.TextAttribute,model);

            //tv.SetAttribute(ShadowEditTextElement.TextChangedAttribute,TextChanged);

            //tv.SetEventAttribute(ShadowEditTextElement.TextChangedAttribute, (t) =>
            //{
            //    if (!firstSet || model != t.Text.ToString())
            //    {
            //        Console.WriteLine($"Settings Text to '{t.Text.ToString()}'");
            //    }
            //    else
            //    {

            //    }

            //    firstSet = false;

            //    this.SetState(t.Text.ToString());
            //});

            //   return tv;
        }

        private void TextChanged(AfterTextChangedEventArgs args)
        {
            Console.WriteLine($"Settings Text to '{args.Editable.ToString()}'");
            //this.SetState(args.Editable.ToString());
        }

    }




    public class UserDetailsXLayout
    {
        public static IPrimitive PerformLayout(UserDetails userDetails)
        {
            var model = userDetails.Context.Owner.GetModel(userDetails);

            //var tv = new ShadowTextViewElement();
            //tv.Attributes.SetAttribute(ShadowTextViewElement.TextAttribute,model);
            return null;
        }
    }



    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class NewMainActivity : BuildActivity
    {
        private UserDetails _userDetails;

        public override void Init(BuildEnvironment buildEnvironment)
        {
            _userDetails = new UserDetails(buildEnvironment);
        }

        protected override IPrimitive PerformLayout(LayoutContext layoutContext) =>
            new Activity(this, _userDetails.Layout(layoutContext))
                .Title("Edit User Details")
                .Call((a, p) => a.SetPersistent(p), true);
    }


    // lets use the activity as an example the codde wants to look like what it is above, but without the call to layout
    // Activity is a primitive control, and SO, it can't have items like that...
    // similarly any native, primitive control, can't be constructed of non primitive elements
    // so...

    // and if a primitive contains a 'non-primitive' then the problem just moves on...
    // 'something' needs to do the 'call' the layout for 'us'
    // a map control say needs to be seen to be convertible to a IPrimitive, but its okay being referenced in the view layout...
    // now, is there a way of indicating that a list can contain something that is 'either' a primitive or something
    // that could be converted to a primitive ? That implies that it needs to be some common type interface for it to be valid ?
    // OR, IViewComponent is always allowed but the 'performLayout' for the control invokes that for each item , but that then
    // results in another instance of the same class ?

    public class Layout
    {
        public Action<BuildEnvironment> Init { get; set; }

        public Func<LayoutContext, IPrimitive> Perform { get; set; }

        public static Layout Create(Action<BuildEnvironment> init, Func<LayoutContext, IPrimitive> perform)
        {
            return new Layout(init, perform);
        }

        public Layout(Action<BuildEnvironment> init, Func<LayoutContext, IPrimitive> perform)
        {
            Init = init;
            Perform = perform;
        }
    }

    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            var loggerFactory =
                new LoggerFactory();
                loggerFactory.AddProvider(new Microsoft.Extensions.Logging.Debug.DebugLoggerProvider());

                Logging.Set(loggerFactory.CreateLogger("xamarin"));
            /*
            var rf = new ReflectedComponent<Button>();


            rf.Set(b => b.Text, "this is text");

            var xx = new ReflectedComponent<Button>.ShadowHandler();

            var ac = new NewAndroidContext(null,this,(x) => null,null);


            TransactionContext.Current.Begin();

            var s= xx.Create(ac, rf);


            xx.Update(ac,s,null,rf);

            TransactionContext.Current.Commit(true);

            Shadow<Button> sb = (Shadow<Button>) s;
            var bt = sb.Item;

            var t = bt.Text;
            */


            /*
            var tv = new ShadowTextViewElement();
            tv.SetAttribute(ShadowTextViewElement.TextAttribute,"this is from code");
            var activity = new Activity(this) {ContentView = tv};
            */

            // CUSTOM LAYOUT PROVIDER LayoutResolver.Current.Register<UserDetailsX>( new UserDetailsXLayoutProvider());


            //var mvu = new DroidBuildHost(new ConsoleLayoutMonitor(),new DefaultErrorPolicy());//new ConsoleLayoutMonitor());//new DefaultLayoutErrorPolicy());//,new ConsoleLayoutMonitor());

            //_dis = mvu.Create(this.ApplicationContext, () => 0, (lc, i) => activity);

            //is = mvu.Create(this, (c,lc) => new AppStatefulContainer(this,c));

            var host = BuildHost.Create(this, (c, lc) => new AppStatefulContainer(this, c));

            _dis = host.Start();
        }


        //        protected override void OnCreate(Bundle savedInstanceState)
//        {
//            base.OnCreate(savedInstanceState);
//            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

//            ContainerStateBag sb = new ContainerStateBag();

//            Stopwatch sw = Stopwatch.StartNew();

//            //SetContentView(Resource.Layout.activity_main);

//            var tv = new TextViewMk4();

//            var vf = new NewViewFactory();

//            var lc = AndroidContext.Create(vf,this,(d) => new Android.Views.ViewGroup.LayoutParams(d.Width,d.Height),new ContainerStateBag());

//            var layout = tv.Build(lc,new TestModel());

//            IShadowView view;

//            using (var transaction = ShadowView.DefaultTransactionLog.Begin())
//            {

//                view = GetViewMk4(lc, layout);

//                var t1 = sw.ElapsedMilliseconds;
//                //var v2 = GetViewMk3();
//                var t2 = sw.ElapsedMilliseconds;

//                // we need to commit the changes here
//                transaction.Commit();

//                SetContentView(((IShadowView<View>)view).View);
//            }


//            // now the view should be setup

//            var t3 = sw.ElapsedMilliseconds;

//            // we would need a mechanism to a) extract this from 
//            // the called back views 
//            // 
//            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
//         //   SetSupportActionBar(toolbar);

//           // FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
////            fab.Click += FabOnClick;

//            NewViewElement prior = layout;
//            NewViewElement current;

//            //ViewFactory2 vf = new ViewFactory2();


//            Observable.Interval(TimeSpan.FromMilliseconds(1000),
//                TaskPoolScheduler.Default).
//                Select(v => tv.Build(lc, new TestModel(){ Amount=(int)(v)})).
//                Select(current =>
//                {
//                    //var transactions = new UiTransactionLog();
//                    //ShadowView._transactions = transactions;

//                    Transactions t;

//                    using (var transaction = ShadowView.DefaultTransactionLog.Begin())
//                    {

//                        vf.Update(lc, view, prior, current);

//                        t= transaction.Commit(false);
//                    }

//                    prior = current;
//                    return t;
//                }).
//                Where(c => c.Present).
//                ObserveOn(HandlerScheduler.MainThreadScheduler)
//                .Do(current =>
//                {
//                    try
//                    {
//                        var tx = current.Count;

//                        Stopwatch sw = Stopwatch.StartNew();

//                        current.Apply();

//                        Log.Info("MVU", $"{tx} User change took {sw.ElapsedMilliseconds}");
//                    }
//                    catch (Exception e)
//                    {
//                        Console.WriteLine(e);
//                    }
//                    // GetViewMk3(current);
//                }).

//                Subscribe();

//            /*
//            Observable.Interval(TimeSpan.FromMilliseconds(1000),HandlerScheduler.MainThreadScheduler).
//                Do(v =>
//                {
//                    try
//                    {
//                        var s = Stopwatch.StartNew();

//                        var tv = new TestView();

//                        current = tv.Build(null, (int)v);

//                        var t1 = s.ElapsedMilliseconds;
//                        vf.Update(view,prior,current);

//                        var t2 = s.ElapsedMilliseconds;
//                        prior = current;

//                        Log.Info("MVUE", $"UI Update took {t1}:{t2 - t1}");

//                    }
//                    catch (Exception e)
//                    {
//                        Console.WriteLine(e);
//                        throw;
//                    }
//                   // GetViewMk3(current);
//                }).

//                Subscribe();
//                */
//        }

        private int HeightFromResource(int resourceId)
        {
            var sa = this.Theme.ObtainStyledAttributes(new int[] {resourceId});

            var height = sa.GetDimension(0, 0);

            sa.Recycle();

            return (int) height;
        }


        private Android.Graphics.Color FromResource(int resourceId)
        {
            var sa3 = this.Theme.ObtainStyledAttributes(new int[] {Resource.Attribute.colorPrimary});
            var color = sa3.GetColor(0, 0);

            return color;
        }

        private readonly ViewRef<Android.Widget.TextView> _firstTextView = new ViewRef<Android.Widget.TextView>();
        private IDisposable _dis;

        //public ViewElement GetViewLayout(int val)
        //{
        //    var layout = ViewElement.CoordinatorLayout(dimensions: Dimensions.MatchMatch,
        //        children: new ViewElement[]
        //        {
        //            ViewElement.RelativeLayout(dimensions: Dimensions.MatchMatch,
        //                children: new ViewElement[]
        //                {
        //                    ViewElement.TextView($"hello world {val}!",
        //                        created: Created,
        //                        layoutRules: new[] {LayoutRules.CenterInParent},
        //                        dimensions: Dimensions.WrapWrap)
        //                })
        //        });

        //    return layout;
        //}

        //public ViewElement GetViewLayoutC2(int val)
        //{
        //    var layout = ViewElement.CoordinatorLayout(dimensions: Dimensions.MatchMatch,
        //        children: new ViewElement[]
        //        {
        //            ViewElement.DependsOn(() => $"{val / 10}", () =>
        //                ViewElement.RelativeLayout(dimensions: Dimensions.MatchMatch,
        //                    children: new ViewElement[]
        //                    {
        //                        ViewElement.RecyclerView(dimensions: Dimensions.MatchWrap, items:
        //                            Range(0, 10).Select(i => ViewElement.TextView($"hello world {val} {i}!",
        //                                created: Created,
        //                                layoutRules: new[] {LayoutRules.CenterInParent},
        //                                dimensions: Dimensions.WrapWrap))
        //                        )
        //                    }
        //                ))
        //        });

        //    return layout;
        //}


        private void CreateRV()
        {
            var rv = new RecyclerView(this);
        }



        //public View GetViewMk2()
        //{
        //    var layout = new CoordinatorLayoutStub()
        //    {
        //        new AppBarLayoutStub()
        //        {
        //            Children = new List<ViewElement>
        //            {
        //                new ToolbarStub(Android.Views.ViewGroup.LayoutParams.MatchParent,
        //                    HeightFromResource(Resource.Attribute.actionBarSize))
        //                {
        //                    Id = Resource.Id.toolbar,
        //                    Color = FromResource(Resource.Attribute.colorPrimary),
        //                    PopupTheme = Resource.Style.AppTheme_PopupOverlay
        //                }
        //            },
        //            Theme = Resource.Style.AppTheme_AppBarOverlay
        //        },
        //        new RelativeLayoutStub()
        //        {
        //            Children = new List<ViewElement>()
        //            {
        //                new TextStub(text: "hello world!") {Rules = new LayoutRules[] {LayoutRules.CenterInParent}}
        //            },
        //        },
        //        new FloatingActionButton(Android.Views.ViewGroup.LayoutParams.WrapContent,
        //            Android.Views.ViewGroup.LayoutParams.WrapContent, gravity: GravityFlags.End | GravityFlags.Bottom)
        //        {
        //            Drawable = this.Resources.GetDrawable(Android.Resource.Drawable.IcDialogEmail, this.Theme),
        //            Margin = (int) Resources.GetDimension(Resource.Dimension.fab_margin),
        //            // THIS would need to be some replacement command being passed back to the common 'handler'
        //            Click = FabOnClickV2
        //        }
        //    };

        //    var vf = new ViewFactory();

        //    return vf.Create(this, layout);
        //}

        public Android.Views.View GetView()
        {
            /*
            <android.support.design.widget.CoordinatorLayout xmlns:android="http://schemas.android.com/apk/res/android"
            xmlns:app="http://schemas.android.com/apk/res-auto"
            xmlns:tools="http://schemas.android.com/tools"
            android:layout_width="match_parent"
            android:layout_height="match_parent">

                <android.support.design.widget.AppBarLayout
            android:layout_width="match_parent"
            android:layout_height="wrap_content"
            android:theme="@style/AppTheme.AppBarOverlay">

                <android.support.v7.widget.Toolbar
            android:id="@+id/toolbar"
            android:layout_width="match_parent"
            android:layout_height="?attr/actionBarSize"
            android:background="?attr/colorPrimary"
            app:popupTheme="@style/AppTheme.PopupOverlay" />

                </android.support.design.widget.AppBarLayout>

                <include layout="@layout/content_main" />

                <android.support.design.widget.FloatingActionButton
            android:id="@+id/fab"
            android:layout_width="wrap_content"
            android:layout_height="wrap_content"
            android:layout_gravity="bottom|end"
            android:layout_margin="@dimen/fab_margin"
            app:srcCompat="@android:drawable/ic_dialog_email" />

                </android.support.design.widget.CoordinatorLayout>
                */

            var view = new CoordinatorLayout(this)
            {
                LayoutParameters = new CoordinatorLayout.LayoutParams(Android.Views.ViewGroup.LayoutParams.MatchParent,
                    Android.Views.ViewGroup.LayoutParams.MatchParent)
            };

            var ctw = new ContextThemeWrapper(this, Resource.Style.AppTheme_AppBarOverlay);

            var appBarLayout = new AppBarLayout(ctw)
            {
                LayoutParameters = new Android.Views.ViewGroup.LayoutParams(
                    Android.Views.ViewGroup.LayoutParams.MatchParent, Android.Views.ViewGroup.LayoutParams.WrapContent),
            };

            view.AddView(appBarLayout);


            var sa = this.Theme.ObtainStyledAttributes(new int[] {Resource.Attribute.actionBarSize});

            var tbHeight = sa.GetDimension(0, 0);

            sa.Recycle();


            var tb = new Android.Support.V7.Widget.Toolbar(appBarLayout.Context)
            {
                LayoutParameters =
                    new Android.Views.ViewGroup.LayoutParams(Android.Views.ViewGroup.LayoutParams.MatchParent,
                        (int) tbHeight)
            };
            tb.Id = Resource.Id.toolbar;

            var sa3 = this.Theme.ObtainStyledAttributes(new int[] {Resource.Attribute.colorPrimary});
            var color = sa3.GetColor(0, 0);


            tb.SetBackgroundColor(color);
            tb.PopupTheme = Resource.Style.AppTheme_PopupOverlay;

            appBarLayout.AddView(tb);

            var sa2 = this.Theme.ObtainStyledAttributes(new int[] {Resource.Dimension.fab_margin});

            var margin = (int) sa2.GetDimension(0, 0);

            //sa2.GetDimensionPixelSize()
            var margin2 = sa2.GetDimensionPixelOffset(0, 0);

            var dim3 = (int) Resources.GetDimension(Resource.Dimension.fab_margin);

            margin2 = dim3;

            sa2.Recycle();

            var rlp = new CoordinatorLayout.LayoutParams(Android.Views.ViewGroup.LayoutParams.MatchParent,
                Android.Views.ViewGroup.LayoutParams.MatchParent);

            rlp.Behavior = new AppBarLayout.ScrollingViewBehavior();

            //var rl = RelativeLayout(null)
            //{
            //    LayoutParameters = rlp
            //};

            //var txtlp = new RelativeLayout.LayoutParams(Android.Views.ViewGroup.LayoutParams.WrapContent,
            //    Android.Views.ViewGroup.LayoutParams.WrapContent);

            //txtlp.AddRule(LayoutRules.CenterInParent);

            //var textView = new Android.Widget.TextView(this)
            //{
            //    LayoutParameters = txtlp
            //};

            //textView.Text = "Hello World!";

            //rl.AddView(textView);

            //view.AddView(rl);

            //var fbLayoutParameters =
            //    new CoordinatorLayout.LayoutParams(Android.Views.ViewGroup.LayoutParams.WrapContent,
            //            Android.Views.ViewGroup.LayoutParams.WrapContent)
            //        {Gravity = (int) (GravityFlags.Bottom | GravityFlags.End)};
            //fbLayoutParameters.SetMargins(margin2, margin2, margin2, margin2);

            //var fb = new Android.Support.Design.Widget.FloatingActionButton(this)
            //{
            //    LayoutParameters = fbLayoutParameters
            //};

            //fb.Id = Resource.Id.fab;

            //fb.SetImageDrawable(this.Resources.GetDrawable(Android.Resource.Drawable.IcDialogEmail, this.Theme));

            //view.AddView(fb);

            return view;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }


        private void FabOnClickV2(Android.Support.Design.Widget.FloatingActionButton fab)
        {
            Snackbar.Make(fab, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener) null).Show();
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            //   SetContentView(Resource.Layout.content_main);

            var view = (Android.Views.View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener) null).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions,
            [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }


    //public class RvAdapter : RecyclerView.Adapter
    //{
    //    private readonly LayoutContext _context;
    //    private ViewFactory2 _viewFactory;


    //    public RvAdapter(LayoutContext context)
    //    {
    //        _context = context;

    //        _viewFactory = context.Factory;
    //    }

    //    // if the source is updated, how do we know what to do... ?
    //    // 

    //    public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
    //    {
    //        (holder as ViewHolder).Update(Elements[position]);
    //    }

    //    public override RecyclerView.ViewHolder OnCreateViewHolder(Android.Views.ViewGroup parent, int viewType)
    //    {
    //        // we need a unique view type per position

    //        // need to create the view in some way...
    //        // the view type is a 'key' to this, but ....
    //        // perhaps if we have the view, we could use the update mechanism that the collection has


    //        // create the view - given the view type we need to...
    //        var viewElement = GetViewElementForType(viewType);

    //        return new ViewHolder(_viewFactory, _viewFactory.Create(_context, viewElement), viewElement);
    //    }

    //    private ViewElement GetViewElementForType(int viewType)
    //    {
    //        return Elements[0];
    //    }

    //    private int _viewTypeCounter;

    //    public override int GetItemViewType(int position)
    //    {
    //        // okay, so need to lookup in the data what the view type is...
    //        return 0;
    //    }

    //    public override int ItemCount => Elements.Count;
    //    public List<ViewElement> Elements { get; set; }

    //}


    //public class NewRvAdapter:RecyclerView.Adapter
    //{
    //    private readonly AndroidContext _context;
    //    private readonly NewViewFactory _viewFactory;

    //    private readonly List<ElementViewType> _elements = new List<ElementViewType>();

    //    private readonly Dictionary<int,int> _elementViewTypeMap = new Dictionary<int, int>();

    //    private struct ElementViewType
    //    {
    //        public int ViewType { get; }

    //        public NewViewElement Element { get; }

    //        public ElementViewType(int viewType, NewViewElement element)
    //        {
    //            ViewType = viewType;
    //            Element = element;
    //        }
    //    }

    //    private int _positionCounter = 0;


    //    public void Insert(int position, NewViewElement element)
    //    {
    //        var newPosition = Interlocked.Increment(ref _positionCounter);

    //        var evt = new ElementViewType(newPosition, element);
    //        _elements.Insert(position,evt);
    //        _elementViewTypeMap[evt.ViewType] = position;
    //    }

    //    public void RemoveAt(int position)
    //    {
    //        var evt = _elements[position];
    //        _elements.RemoveAt(position);
    //        _elementViewTypeMap.Remove(evt.ViewType);
    //    }

    //    public void Update(int position, NewViewElement element)
    //    {
    //        var newPosition = Interlocked.Increment(ref _positionCounter);

    //        var oldEvt = _elements[position];
    //        var newEvt = new ElementViewType(newPosition, element);
    //        _elements[position] = newEvt;
    //        _elementViewTypeMap.Remove(oldEvt.ViewType);
    //        _elementViewTypeMap[newEvt.ViewType] = position;
    //    }

    //    public override int ItemCount => _elements.Count;

    //    public NewRvAdapter(AndroidContext context)
    //    {
    //        _context = context;

    //        _viewFactory = context.Factory;
    //    }

    //    // if the source is updated, how do we know what to do... ?
    //    // 

    //    public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
    //    {
    //        (holder as NewViewHolder).Update(_elements[position].Element);
    //    }

    //    public override RecyclerView.ViewHolder OnCreateViewHolder(Android.Views.ViewGroup parent, int viewType)
    //    {
    //        // create the view - given the view type we need to...
    //        var viewElement = GetViewElementForType(viewType);
    //        var view = _viewFactory.Create(_context, viewElement);

    //        return new NewViewHolder(_context,_viewFactory,view,viewElement);
    //    }

    //    private NewViewElement GetViewElementForType(int viewType)
    //    {
    //        return _elements[_elementViewTypeMap[viewType]].Element;
    //    }

    //    public override int GetItemViewType(int position)
    //    {
    //        // okay, so need to lookup in the data what the view type is...
    //        // this isn't however that good when the item changes but we are using the position
    //        // we need something else...
    //        return _elements[position].ViewType;
    //    }
    //}


    //public class ViewHolder : RecyclerView.ViewHolder
    //{
    //    private readonly ViewFactory2 _viewFactory;
    //    private ViewElement _element;

    //    public ViewHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
    //    {
    //    }

    //    public ViewHolder(ViewFactory2 viewFactory, View itemView, ViewElement element) : base(itemView)
    //    {
    //        _viewFactory = viewFactory;
    //        _element = element;
    //    }

    //    public void Update(ViewElement current)
    //    {
    //        _viewFactory.Update(ItemView, _element, current);
    //        _element = current;
    //    }
    //}




    //public class ViewF
    //{
    //    public View DoCreate(LayoutContext context, ViewElement current)
    //    {
    //        var v = Create(context, current);

    //        if (current.TryGetAttribute<ViewRef>(ViewElement.RefKey, out var viewRef))
    //        {
    //            viewRef.Set(v);
    //        }

    //        // invoke any created callback
    //        current.Created?.Invoke(current, v);

    //        return v;
    //    }

    //    protected virtual View Create(LayoutContext context, ViewElement current)
    //    {
    //        return null;
    //    }

    //    public virtual void Update(LayoutContext context, View target, ViewElement previous, ViewElement current)
    //    {

    //    }

    //    public virtual void Remove(LayoutContext context, ViewElement viewElement)
    //    {

    //    }
    //}


    //public class ViewFactory
    //{
    //    // for each stub we need a 'factory'
    //    // and in the case of android, the parent container should provide in its context
    //    // since, 

    //    private Dictionary<Type, Func<Context, ViewFactory, ViewElement, View>> _viewFactories =
    //        new Dictionary<Type, Func<Context, ViewFactory, ViewElement, View>>()
    //        {
    //            {
    //                typeof(CoordinatorLayoutStub),
    //                (c, vf, s) => ViewFactories.CoordinatorLayoutFactory(c, vf, (CoordinatorLayoutStub) s)
    //            },
    //            {typeof(TextStub), (c, vf, s) => ViewFactories.TextViewFactory(c, vf, (TextStub) s)},
    //            {
    //                typeof(AppBarLayoutStub),
    //                (c, vf, s) => ViewFactories.AppBarLayoutFactory(c, vf, (AppBarLayoutStub) s)
    //            },
    //            {typeof(ToolbarStub), (c, vf, s) => ViewFactories.ToolbarFactory(c, vf, (ToolbarStub) s)},
    //            {
    //                typeof(RelativeLayoutStub),
    //                (c, vf, s) => ViewFactories.RelativeLayoutFactory(c, vf, (RelativeLayoutStub) s)
    //            },
    //            {typeof(FloatingActionButton), (c, vf, s) => ViewFactories.FABFactory(c, vf, (FloatingActionButton) s)},
    //        };


    //    public View Create(Context context, ViewElement viewRoot)
    //    {
    //        var factory = _viewFactories[viewRoot.GetType()];

    //        return factory(context, this, viewRoot);
    //    }


    //}


    //public static class ViewFactories
    //{
    //    public static View CoordinatorLayoutFactory(Context context, ViewFactory vf, CoordinatorLayoutStub stub)
    //    {
    //        var cl = new CoordinatorLayout(context);

    //        foreach (var subStub in stub)
    //        {
    //            var v = vf.Create(cl.Context, subStub);

    //            cl.AddView(v);

    //        }

    //        return cl;
    //    }

    //    public static Android.Widget.TextView TextViewFactory(Context context, ViewFactory vf, TextStub stub)
    //    {
    //        var tv = new Android.Widget.TextView(context);

    //        var lp = new RelativeLayout.LayoutParams(0, 0); ///TDB

    //        if (stub.Rules != null)
    //        {
    //            foreach (var rule in stub.Rules)
    //            {
    //                lp.AddRule(rule);
    //            }
    //        }

    //        tv.LayoutParameters = lp;

    //        tv.Text = stub.Text;

    //        return tv;
    //    }


    //    //public static Android.Support.Design.Widget.FloatingActionButton FABFactory(Context context, ViewFactory vf,
    //    //    FloatingActionButton stub)
    //    //{
    //    //    var fab = new Android.Support.Design.Widget.FloatingActionButton(context);

    //    //    var lp = new CoordinatorLayout.LayoutParams(0, 0); // TBDstub.Width,stub.Height);

    //    //    lp.Gravity = (int) stub.Gravity;
    //    //    lp.SetMargins(stub.Margin, stub.Margin, stub.Margin, stub.Margin);

    //    //    fab.LayoutParameters = lp;

    //    //    if (stub.Drawable != null)
    //    //    {
    //    //        fab.SetImageDrawable(stub.Drawable);
    //    //    }

    //    //    fab.Click += delegate(object sender, EventArgs args)
    //    //    {
    //    //        stub.Click(sender as Android.Support.Design.Widget.FloatingActionButton);
    //    //    };

    //    //    return fab;
    //    //}

    //    //public static AppBarLayout AppBarLayoutFactory(Context context, ViewFactory vf, AppBarLayoutStub stub)
    //    //{
    //    //    Context ctw;

    //    //    if (stub.Theme != 0)
    //    //    {
    //    //        ctw = new ContextThemeWrapper(context, stub.Theme);
    //    //    }
    //    //    else
    //    //    {
    //    //        ctw = context;
    //    //    }

    //    //    var abl = new AppBarLayout(ctw);

    //    //    var lp = new CoordinatorLayout.LayoutParams(0, 0); //TBD

    //    //    abl.LayoutParameters = lp;

    //    //    foreach (var subStub in stub)
    //    //    {
    //    //        var v = vf.Create(abl.Context, subStub);

    //    //        abl.AddView(v);
    //    //    }



    //    //    return abl;
    //    //}

    //    //public static Android.Support.V7.Widget.Toolbar ToolbarFactory(Context context, ViewFactory vf,
    //    //    ToolbarStub stub)
    //    //{
    //    //    var toolBar = new Android.Support.V7.Widget.Toolbar(context);

    //    //    var lp = new Android.Views.ViewGroup.LayoutParams(0, 0); //TBD

    //    //    toolBar.LayoutParameters = lp;

    //    //    if (stub.PopupTheme != 0)
    //    //    {
    //    //        toolBar.PopupTheme = stub.PopupTheme;
    //    //    }

    //    //    toolBar.SetBackgroundColor(stub.Color);
    //    //    toolBar.Id = stub.Id;

    //    //    return toolBar;
    //    //}

    //    //public static RelativeLayout RelativeLayoutFactory(Context context, ViewFactory vf, RelativeLayoutStub stub)
    //    //{
    //    //    var cl = new RelativeLayout(context);

    //    //    var lp = new RelativeLayout.LayoutParams(0, 0); //TBD

    //    //    if (stub.Rules != null)
    //    //    {
    //    //        foreach (var rule in stub.Rules)
    //    //        {
    //    //            lp.AddRule(rule);
    //    //        }
    //    //    }

    //    //    cl.LayoutParameters = lp;

    //    //    foreach (var subStub in stub)
    //    //    {
    //    //        var v = vf.Create(cl.Context, subStub);

    //    //        cl.AddView(v);

    //    //    }


    //    //    return cl;

    //    //}
    //}


    //public class FloatingActionButton : ViewElement
    //{
    //    public GravityFlags Gravity { get; }
    //    public int Margin { get; set; }

    //    private static AttributeKey<GravityFlags> GravityKey = new AttributeKey<GravityFlags>("gravity");
    //    private static AttributeKey<int> MarginKey = new AttributeKey<int>("margin");


    //    public Android.Graphics.Drawables.Drawable Drawable { get; set; }


    //    public static FloatingActionButton View( /* parameters here*/)
    //    {
    //        return new FloatingActionButton(0, 0, GravityFlags.AxisClip);
    //    }

    //    // this create method could/would possibly be different...on iOS , 
    //    // how would we accomodate this?

    //    public Android.Support.Design.Widget.FloatingActionButton Create(Context context)
    //    {

    //        return new Android.Support.Design.Widget.FloatingActionButton(context);
    //    }

    //    public void Update(Android.Support.Design.Widget.FloatingActionButton target, FloatingActionButton previous,
    //        FloatingActionButton source)
    //    {
    //        // need to update the inherited items here...

    //        // we update the properties here...
    //        source.UpdatePrimitive(previous, target, GravityKey, (v) => target.ForegroundGravity,
    //            (t, v) => t.SetForegroundGravity(v));
    //    }

    //    private void UpdatePrimitive<TTarget, TItem>(FloatingActionButton previous, TTarget target,
    //        AttributeKey<TItem> attribute, Func<TTarget, TItem> getFunc, Action<TTarget, TItem> setFunc)
    //    {
    //        throw new NotImplementedException();
    //    }


    //    public ViewRef<Android.Support.Design.Widget.FloatingActionButton> Ref { get; set; }

    //    public FloatingActionButton(int width, int height, GravityFlags gravity, int margin = 0) : base()
    //    {
    //        Gravity = gravity;
    //        Margin = margin;
    //    }

    //    public Action<Android.Support.Design.Widget.FloatingActionButton> Click;
    //}

    //public class AppBarLayoutStub : ViewElementContainer
    //{
    //    public AppBarLayoutStub(int width = Android.Views.ViewGroup.LayoutParams.MatchParent,
    //        int height = Android.Views.ViewGroup.LayoutParams.WrapContent) : base() //TBD
    //    {
    //    }

    //    public int Theme { get; set; }

    //}




    //public class TextViewMk4
    //{
    //    private readonly int _noItems;
    //    private static NewCoordinatorLayout _cur;

    //    public TextViewMk4(int noItems=100) => _noItems = noItems;

    //    public NewViewElement Build(AndroidContext buildContext, TestModel model)
    //    {
    //        var cl = new NewCoordinatorLayout();

    //        var text = Range(0, 10).Select(r =>
    //        {
    //            var tv = new NewTextViewElement() {Dimensions = Dimensions.MatchWrap};
    //            tv.SetAttribute(NewTextViewElement.TextAttribute, $"hello world !!!!!{model.Amount * 10 + r}");

    //            return tv;
    //        });

    //        var rl = new NewLinearLayoutViewElement();

    //        rl.SetAttribute(NewLinearLayoutViewElement.OrientationAttribute,Orientation.Vertical);
    //        rl.Dimensions = Dimensions.MatchWrap;

    //        var edit = new NewEditTextViewElement();
    //        edit.SetAttribute(NewEditTextViewElement.TextAttribute,model.EditText);

    //        if ((model.Amount % 2) == 0)
    //        {
    //            edit.SetEventAttribute(NewEditTextViewElement.TextChangedAttribute, (e)
    //                    =>
    //                {
    //                    // now need to issue a 'command' with the text back to the overall container...
    //                    Console.WriteLine($"Even Text Changed {e.Text}");
    //                }
    //            );
    //        }

    //        else
    //        {
    //            edit.SetEventAttribute(NewEditTextViewElement.TextChangedAttribute, (e)
    //                    =>
    //                {
    //                    // now need to issue a 'command' with the text back to the overall container...
    //                    Console.WriteLine($"Odd Text Changed {e.Text}");
    //                }
    //            );

    //        }

    //        edit.Dimensions = Dimensions.MatchWrap;



    //        var rv = new NewRecyclerViewElement {Dimensions = Dimensions.MatchWrap};

    //        rv.SetAttribute(NewRecyclerViewElement.ItemsAttribute, Range(0,1000).Select(i =>
    //        {
    //            var tv = new NewTextViewElement() {Dimensions = Dimensions.MatchWrap};
    //            tv.SetAttribute(NewTextViewElement.TextAttribute, $"Recycler View !!!!!{model.Amount  + i}");

    //            return (NewViewElement)tv;

    //        }).ToArray());

    //        rl.Children = (new NewViewElement[]{edit}.Concat(text)).Concat(rv).ToArray();
    //        cl.Children = new NewViewElement[]{rl};

    //        return cl;

    //    }

    //}

    //public class TestView : IModelView<int>
    //{
    //    private readonly int _noItems;

    //    public TestView(int noItems = 10000) => _noItems = noItems;

    //    public ViewElement Build(IBuildContext buildContext, int model)
    //    {
    //        var layout = ViewElement.CoordinatorLayout(dimensions: Dimensions.MatchMatch,
    //            children: new ViewElement[]
    //            {
    //                ViewElement.RelativeLayout(dimensions: Dimensions.MatchMatch,
    //                    children: new ViewElement[]
    //                    {
    //                        ViewElement.RecyclerView(dimensions: Dimensions.MatchWrap,
    //                            items: Range(0, _noItems).Select(i =>
    //                            {
    //                                int val;

    //                                if (model % 2 == 0)
    //                                {

    //                                    if (i == 0)
    //                                    {
    //                                        val = 0;
    //                                    }
    //                                    else
    //                                    {
    //                                        val = i;
    //                                    }
    //                                }
    //                                else
    //                                {
    //                                    if (i == 0)
    //                                    {
    //                                        val = 0;
    //                                    }
    //                                    else
    //                                    {
    //                                        val = i * 2 + 1;
    //                                    }
    //                                }

    //                                return ViewElement.TextView($"hello world {val}!",
    //                                    dimensions: Dimensions.WrapWrap);
    //                            })
    //                        )
    //                    }
    //                )
    //            });

    //        return layout;
    //    }
    //}
}
