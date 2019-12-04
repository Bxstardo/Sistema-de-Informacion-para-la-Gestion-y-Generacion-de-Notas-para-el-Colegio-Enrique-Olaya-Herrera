using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using RepasoS.scripts;

namespace RepasoS.scripts
{
    public class MessageBox
    {
        public static void alert(string msg)
        {

            string sMsg = msg.Replace("\n", "\\n"); sMsg = msg.Replace("\"", "'");
            StringBuilder sb = new StringBuilder();
            sb.Append(@"<script language='javascript'>"); sb.Append(@"alert( """ +
            sMsg + @""" );"); sb.Append(@"</script>");
            HttpContext.Current.Response.Write(sb.ToString());
        }
    }
    }