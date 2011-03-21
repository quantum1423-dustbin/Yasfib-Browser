using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace fp
{
    class FishPhish
    {
        public static string string2domain(string Url)
        {
            if (!Url.Contains("://"))
                Url = "http://" + Url;

            return new Uri(Url).Host;
        }
        public static bool checkPaypal(string content, string url)
        {
            try
            {
                //System.Windows.Forms.MessageBox.Show(content);
                if (string2domain(url).ToString() != "www.paypal.com")
                {
                    if (content.Contains("i/logo/paypal_logo.gif") ||
                        content.Contains("webscr?cmd=_home"))
                    {
                        return true;
                    }
                    else { return false; }
                }
                else { return false; }
            }
            catch { }
            return false;
        }
        public static bool checkTaobao(string content, string url)
        {
            try
            {
                //System.Windows.Forms.MessageBox.Show(content);
                if (string2domain(url).ToString() != "login.taobao.com")
                {
                    if (content.Contains("<p>移动<em>106575258196</em></p>") ||
                        content.Contains("<h4>您需要安装安全控件，才可使用安全登录。</h4>") ||
                        content.Contains(";if(!''.replace(/^/,String)){while(") ||
                        content.Contains("<span class=\"visitor\" id=\"J_VisitorTips_1\">"))
                    {
                        return true;
                    }
                    else { return false; }
                }
                else { return false; }
            }
            catch { }
            return false;
        }
        public static bool checkAlipay(string content, string url)
        {
            try
            {
                //System.Windows.Forms.MessageBox.Show(content);
                if (string2domain(url).ToString() != "auth.alipay.com")
                {
                    if (content.Contains("<!--CMS大区域开始/标准登录页/标准登录页banner/loginBanner-->") ||
                        content.Contains("h2 seed=\"auth-alipayMember\">") ||
                        content.Contains("login.jhtml?style=alipay&amp;goto=") ||
                        content.Contains("<form name=\"loginForm\" id=\"login\" action=\"https://auth.alipay.com/login/index.htm\" method=\"post\" > "))
                    {
                        return true;
                    }
                    else { return false; }
                }
                else { return false; }
            }
            catch { }
            return false;
        }
        public static bool checkFacebook(string content, string url)
        {
            try
            {
                //System.Windows.Forms.MessageBox.Show(content);
                if (string2domain(url).ToString() != "www.facebook.com")
                {
                    if (content.Contains("<!--CMS大区域开始/标准登录页/标准登录页banner/loginBanner-->") ||
                        content.Contains("h2 seed=\"auth-alipayMember\">") ||
                        content.Contains("login.jhtml?style=alipay&amp;goto=") ||
                        content.Contains("<form name=\"loginForm\" id=\"login\" action=\"https://auth.alipay.com/login/index.htm\" method=\"post\" > "))
                    {
                        return true;
                    }
                    else { return false; }
                }
                else { return false; }
            }
            catch { }
            return false;
        }
    }
}
