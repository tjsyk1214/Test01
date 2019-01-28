﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sample01.Models;

namespace Sample01.Controllers
{
    /// <summary>
    /// 2018.11.19
    /// 祝雷
    /// Content控制器
    /// </summary>
    public class ContentController : Controller
    {
        /// <summary>
        /// 首页显示
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var contents = new List<Content>();
            for (int i = 1; i < 11; i++)
            {
                contents.Add(new Content { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-1) });
            }
            return View(new ContentViewModel { Contents = contents });
        }
    }
}