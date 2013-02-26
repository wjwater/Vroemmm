// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Vroemmm.Controllers
{
    public partial class CalendarController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CalendarController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected CalendarController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SelectEvents()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SelectEvents);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ShowEvents()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ShowEvents);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CalendarController Actions { get { return MVC.Calendar; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Calendar";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Calendar";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string SelectCalendar = "SelectCalendar";
            public readonly string SelectEvents = "SelectEvents";
            public readonly string ShowEvents = "ShowEvents";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string SelectCalendar = "SelectCalendar";
            public const string SelectEvents = "SelectEvents";
            public const string ShowEvents = "ShowEvents";
        }


        static readonly ActionParamsClass_SelectEvents s_params_SelectEvents = new ActionParamsClass_SelectEvents();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SelectEvents SelectEventsParams { get { return s_params_SelectEvents; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SelectEvents
        {
            public readonly string calendarId = "calendarId";
        }
        static readonly ActionParamsClass_ShowEvents s_params_ShowEvents = new ActionParamsClass_ShowEvents();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ShowEvents ShowEventsParams { get { return s_params_ShowEvents; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ShowEvents
        {
            public readonly string calendarId = "calendarId";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string SelectCalendar = "SelectCalendar";
                public readonly string SelectEvents = "SelectEvents";
                public readonly string ShowEvents = "ShowEvents";
            }
            public readonly string SelectCalendar = "~/Views/Calendar/SelectCalendar.cshtml";
            public readonly string SelectEvents = "~/Views/Calendar/SelectEvents.cshtml";
            public readonly string ShowEvents = "~/Views/Calendar/ShowEvents.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_CalendarController : Vroemmm.Controllers.CalendarController
    {
        public T4MVC_CalendarController() : base(Dummy.Instance) { }

        partial void SelectCalendarOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult SelectCalendar()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SelectCalendar);
            SelectCalendarOverride(callInfo);
            return callInfo;
        }

        partial void SelectEventsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string calendarId);

        public override System.Web.Mvc.ActionResult SelectEvents(string calendarId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SelectEvents);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "calendarId", calendarId);
            SelectEventsOverride(callInfo, calendarId);
            return callInfo;
        }

        partial void ShowEventsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string calendarId);

        public override System.Web.Mvc.ActionResult ShowEvents(string calendarId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ShowEvents);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "calendarId", calendarId);
            ShowEventsOverride(callInfo, calendarId);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
