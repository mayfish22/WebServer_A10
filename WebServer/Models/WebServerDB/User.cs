// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebServer.Models.WebServerDB;

public partial class User
{
    public string ID { get; set; }

    public string Account { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public string Name { get; set; }

    public string Birthday { get; set; }

    public long IsEnabled { get; set; }

    public virtual ICollection<Card> Card { get; } = new List<Card>();

    public virtual ICollection<ForgotPassword> ForgotPassword { get; } = new List<ForgotPassword>();
}