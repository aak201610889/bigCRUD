//using bigCRUD.Application.Models;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Linq.Dynamic.Core;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace bigCRUD.Application.Helpers
//{
//    public static class ExpressionsHelper
//    {

//        public static Expression<Func<T, object>> Build<T>(this SortBy sortBy)
//        {
//            string sortKey = "x=>x." + sortBy.sortField;
//            var exp = DynamicExpressionParser.ParseLambda<T, object>(ParsingConfig.Default, false, sortKey);
//            return exp;
//        }

//        private const string _empty = " ";
//        public static string AddStringWithSpacer(this string str, bool ignoreCase = false) => _empty + str + (ignoreCase ? ".ToLower()" : "");

//        public static string surroundStringWithQuotes(this string str, bool ignoreCase = false) => ignoreCase ? "\"" + str.ToLower() + "\"" : "\"" + str + "\"";




//        private static bool PropertyTracer(string MemberFullName, System.Reflection.PropertyInfo[] props)
//        {
//            bool propertiesExist = true;
//            Queue<string> Members = new Queue<string>(MemberFullName.Split("."));
//            while (Members.Count > 0)
//            {

//                var Member = Members.Dequeue();
//                var MemberProps = props.Where(x => x.Name.ToLower() == Member.ToLower()).FirstOrDefault();
//                if (MemberProps != null)
//                {
//                    if (Members.Count > 0)
//                    {
//                        var MemberType = MemberProps.PropertyType;
//                        if (MemberType != null)
//                        {
//                            props = MemberType.GetProperty();
//                        }
//                    }
//                }
//                else
//                {
//                    propertiesExist = false;
//                }
//            }
//                return propertiesExist;
            
//        }




//        public static Expression<Func<T, bool>> build<T>(this SearchFilter so)
//        {
//            try
//            {

//                string expression = so.GetExpression<T>();
//                Expression<Func<T, bool>> exp = -=> true;
//                exp = DynamicExpressionParser.ParseLambda<T, bool>(ParsingConfig.Default, false, expression);
//            }
//            catch (Exception e)
//            {
//                var c = e.Message;
//                throw e;
//            }
//        }










//        private static string GetExpression<T>(this SearchOptions so)
//        {
//            try
//            {
//                Type objType = typeof(T);
//                var objProps = objType.GetProperties();
//                List<string> filters = new List<string>();
//                var index = 0;
//                if (objProps.Any(prop => prop.Name.Contains("IsDeleted")) && !so.Filters.Any(m => m.SearchField == "IsDeleted"))
//                {
//                    so.Filters.Add(new SearchFilter() { SearchField = "IsDeleted", SearchOperator = "Equal", SearchFor = false });
//                }

//            }
//            catch (Exception e)
//            {
//                var c = e.Message;
//                throw e;
//            }
//        }






//        public static string ToLowerNullable(this string? str) => str != null ? str.ToLower() : "";





//    }
//}
