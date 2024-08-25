﻿using System.ComponentModel.DataAnnotations.Schema;
using TCSA.V2.Data;

namespace TCSA.V2.Models;

public class ShowcaseItem
{
    public Guid Id { get; set; }= Guid.NewGuid();
    [ForeignKey("ApplicationUser")]
    public string ApplicationUserId { get; set; }
    [ForeignKey("Project")]
    public int ProjectId { get; set; }
    public Area Area { get; set; }
    public DateTime DateCreated { get; set; }= DateTime.Now;
    public bool GoldenProject { get; set; } = false;
    public string Link { get; set; }
    public int? Likes { get; set; } = 0;
    public List<string>? Comments { get; set; }
    public string AreaName
    {
        get
        {
            return Enum.GetName(typeof(Area),Area);
        }
    }

    public string ProjectName { get; set; }

}

