using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eulei.IMemberShip;
namespace ResetPassWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
                Console.Write("请输入功能验证码：");
                string _resetPassWord = Console.ReadLine();
                if (_resetPassWord.Equals("13788821021"))
                {
                    Console.Write("请输入要重置密码的账号名：");
                    string _userName = Console.ReadLine();
                ReReadPassWord:
                    Console.Write("请输入新密码：");
                    string _passWord = Console.ReadLine();
                    Console.Write("请再次输入新密码：");
                    string _passWordtow = Console.ReadLine();
                    if (!_passWord.Equals(_passWordtow))
                    {
                        Console.WriteLine("两次输入密码不一致，请重新输入！");
                        goto ReReadPassWord;
                    }

                    if (Task.Init().MembershipService.ResetPassWord(_userName, _passWord))
                    {
                        Console.WriteLine("重置密码成功");
                    }
                    else
                    {

                        Console.WriteLine("重置密码失败");
                    }


                }
                else
                {
                    Console.WriteLine("功能验证码错误，不能使用密码重置功能！");
                }

                Console.ReadLine();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message+ex.Source.);
            //    Console.ReadLine();
            //}
        }
    }
}
