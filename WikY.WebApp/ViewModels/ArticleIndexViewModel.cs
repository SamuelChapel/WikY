﻿using WikY.WebApp.Models;

namespace WikY.WebApp.ViewModels;

public class ArticleIndexViewModel
{
    public string? Message { get; set; }

    public ArticleDto? Article { get; set; } = null!;
}
