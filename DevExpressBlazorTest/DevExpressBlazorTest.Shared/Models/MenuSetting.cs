using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpressBlazorTest.Shared.Models;

public class MenuSetting
{
    [Key]
    public int MenuId { get; set; }

    public string GroupName { get; set; } = string.Empty;
    public string MenuName { get; set; }
    public string Page { get; set; }
    public string Memo { get; set; } = string.Empty;

    public int Order { get; set; }
}
