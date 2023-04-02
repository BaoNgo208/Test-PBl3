﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;



namespace PBL3_QLQuanNet.BLL
{
    public class QuanLiTaiKhoan
    {

      
        public  static  string MD5Hash(string input)
        {
            QuanLyNet2DataContext db = new QuanLyNet2DataContext();
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
           
        }
    }
}
