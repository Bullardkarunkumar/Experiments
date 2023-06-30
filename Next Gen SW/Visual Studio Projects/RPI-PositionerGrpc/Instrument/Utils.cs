using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;

namespace Ets.Common
{
    public class Utils
    {
        public T Cast<T>(object o)
        {
            if (o is T)
                return (T)o;

            return default(T);
        }

        public static bool IsNull(Object o)
        {
            return o == null;
        }

        public static bool IsNull(Object o, params object[] argsRest)
        {
            if (IsNull(o))
                return true;

            foreach (object x in argsRest)
            {
                if (IsNull(x))
                    return true;
            }
            return false;
        }

        public static bool IsNotNull(Object o)
        {
            return !IsNull(o);
        }

        public static bool IsNotNull(Object o, params object[] arsRest)
        {
            return !IsNull(o,arsRest);
        }

        public static bool IsEmpty(String s)
        {
            if (IsNull(s))
                return true;

            return s.Length == 0;
        }

        public static bool IsNotEmpty(String s)
        {
            return !IsEmpty(s);
        }

 
        public static bool IsEmpty(System.Collections.ArrayList arrayList)
        {
            if (Utils.IsNull(arrayList))
                return true;

            return arrayList.Count == 0;
        }

        public static bool IsNotEmpty(ArrayList a)
        {
            return !IsEmpty(a);
        }

        internal static bool IsValidIndex(ArrayList a, int index)
        {
            if (index < 0)
                return false;

            return (index < a.Count);
        }

        public static bool IsNotValidIndex(ArrayList a, int index)
        {
            return !IsValidIndex(a, index);
        }

        public static bool MoveUp(ArrayList a, object o)
        {
            int index = a.IndexOf(o);

            return MoveUp(a, index);
        }

        public static bool MoveDown(ArrayList a, object o)
        {
            int index = a.IndexOf(o);

            return MoveDown(a, index);
        }

        public static bool MoveUp(ArrayList a, int index)
        {
            if (Utils.IsNotValidIndex(a, index))
                return false;

            // at top already
            if (index <= 0)
                return false;

            object saved = a[index];
            a.RemoveAt(index);
            index--;
            a.Insert(index, saved);

            return true;
        }

        public static bool MoveDown(ArrayList a, int index)
        {
            if (Utils.IsNotValidIndex(a, index))
                return false;

            // at bottom already
            if (index >= (a.Count - 1))
                return false;

            object saved = a[index];
            a.RemoveAt(index);
            index++;
            a.Insert(index, saved);

            return true;
        }

        public static string GetEnumDescription(Enum value)
        {
            System.Reflection.FieldInfo fi = value.GetType().GetField(value.ToString());

            System.ComponentModel.DescriptionAttribute[] attributes =
                (System.ComponentModel.DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(System.ComponentModel.DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        internal static bool Replace(ArrayList a, int index, object o)
        {
            if (Utils.IsNotValidIndex(a,index))
                return false;

            a.RemoveAt(index);
            a.Insert(index, o);
            return true;
        }

        public static bool IsNotEmpty(object[] os)
        {
            return !IsEmpty(os);
        }

        public static bool IsEmpty(object[] os)
        {
            if (Utils.IsNull(os))
                return true;

            return (os.Length == 0);
        }

        public static void Noop(Exception ex)
        {
          //  Log it
        }

        public static string ApplicationAssemblyVersion
        {
            get
            {
                System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                string versionString = a.GetName().Version.ToString();

                return versionString;
            }
        }

        public static DateTime ApplicationAssemblyDate
        {
            get
            {
                return AssemblyDate(System.Reflection.Assembly.GetEntryAssembly());
            }
        }

        public static DateTime AssemblyDate(System.Reflection.Assembly a)
        {
           // get
            {
       //         System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                Version v = a.GetName().Version;//.ToString();

                DateTime d = new DateTime(2000, 1, 1);
                d=d.AddDays(v.Build);
                d=d.AddSeconds(v.Revision * 2);

                if (TimeZone.IsDaylightSavingTime(DateTime.Now, TimeZone.CurrentTimeZone.GetDaylightChanges(DateTime.Now.Year)))
                {
                    d=d.AddHours(1);
                }

                return d;
            }
        }


        public static string CurrentAssemblyVersion
        {
            get
            {
                System.Reflection.Assembly a = System.Reflection.Assembly.GetCallingAssembly();
                string versionString = a.GetName().Version.ToString();
                return versionString;
            }
        }

        public static DateTime CurrentAssemblyDate
        {
            get
            {
                return AssemblyDate(System.Reflection.Assembly.GetCallingAssembly());
            }
        }

        public static String ThisMethodName
        {
            get
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                MethodBase methodBase = stackFrame.GetMethod();
                return methodBase.Name;
            }
        }

    } 
}

