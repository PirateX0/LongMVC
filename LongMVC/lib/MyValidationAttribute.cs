using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LongMVC.lib
{
    public class QQNumberAttribute: RegularExpressionAttribute
    {
        public QQNumberAttribute() : base(@"^\d{5,10}$")//不要忘了^$
        {
            this.ErrorMessage = "{0}属性不是合法的QQ号，QQ号需要5-10位数字";
            //设定ErrorMessage的默认值。使用的人也可以覆盖这个值
        }

    }

    public class CNPhoneNumAttribute : ValidationAttribute
    {
        public CNPhoneNumAttribute()
        {
            this.ErrorMessage = "电话号码必须是固话或者手机，固话要是3-4位区号开头，手机必须以13、15、18、17开头";
        }
        //注意，不要override ValidationResult IsValid(object value, ValidationContext validationContext)
        public override bool IsValid(object value)
        {
            if (value is string)
            {
                string s = (string)value;

                if (s.Length == 13)//手机号
                {
                    if (s.StartsWith("13") || s.StartsWith("15") || s.StartsWith("17") || s.StartsWith("18"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (s.Contains("-"))//固话
                {
                    //010,021 0755 0531
                    string[] strs = s.Split('-');
                    if (strs[0].Length == 3 || strs[0].Length == 4)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }




}