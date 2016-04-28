﻿using UnityEngine;
using System.Collections;

namespace JPush {

	public class CustomEventObj : CustomEvent
	{
		//JPush event types
		public static string EVENT_JPUSH = "event_jpush";
		public static string EVENT_INIT_JPUSH = "event_init_jpush";
		public static string EVENT_STOP_JPUSH = "event_stop_jpush";
		public static string EVENT_RESUME_JPUSH = "event_resume_jpush";
		public static string EVENT_SET_TAGS = "event_set_tags";
		public static string EVENT_SET_ALIAS = "event_set_alias";
		public static string EVENT_SET_PUSH_TIME = "event_set_push_time";
		public static string EVENT_ADD_LOCAL_NOTIFICATION = "event_add_local_notification";
		public static string EVENT_REMOVE_LOCAL_NOTIFICATION = "event_remove_local_notification";
		public static string EVENT_CLEAR_LOCAL_NOTIFICATION = "event_clear_local_notification";

		// optionally add custom variables instead of using the arguments hashtable
		public int myCustomEventVar1 = 0;
		public bool rockOn = true;

		public CustomEventObj(string eventType = "")
		{
			type = eventType;
		}

	}

}
