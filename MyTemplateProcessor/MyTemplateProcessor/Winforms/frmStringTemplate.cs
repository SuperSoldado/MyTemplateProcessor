using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cottle;
using Newtonsoft.Json;

namespace WinForms.StringTemplate;



public partial class frmStringTemplate : Form
{
    public frmStringTemplate()
    {
        InitializeComponent();

        string rootPath = Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);

        var templatePath = Path.Combine(
            rootPath,
            "Winforms\\Template\\MyTemplate.ts");

        if (!File.Exists(templatePath))
        {
            txtTemplate.Text = "File not found" + templatePath;
        }
        else
        {
            txtTemplate.Text = File.ReadAllText(templatePath);
        }

        var input = new MyInput();
        input.itens.Add("item #0");
        input.itens.Add("item #1");
        input.itens.Add("item #2");
        input.x = -3;
        input.test = 42;
        var example = JsonConvert.SerializeObject(input, Formatting.Indented);
        txtParameters.Text = example;
    }

    private void btnRun_Click(object sender, EventArgs e)
    {
        try
        {
            // Create from template string
            var documentResult = Document.CreateDefault(txtTemplate.Text);

            // Throws ParseException on error
            var document = documentResult.DocumentOrThrow;

            var parameters =
                JsonConvert.DeserializeObject<MyInput>(txtParameters.Text);

            var dict2 = MyHelper.ConvertToDict(parameters);

            var context = Context.CreateBuiltin(dict2);

            // TODO: customize rendering if needed

            var result = document.Render(context);
            txtOutput.Text = result;
        }
        catch (Exception ex)
        {
            txtOutput.Text = ex.Message;
        }

    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        OpenUrl.Open(linkLabel1.Text);
    }
}


public class MyInput
{
    public int test { get; set; }
    public int x { get; set; }
    public List<string> itens { get; set; } = new List<string>();
}

public static class MyHelper
{
    public static Dictionary<Value, Value> ConvertToDict(MyInput input)
    {
        var dict = new Dictionary<Value, Value>();

        List<Value> abc = new List<Value>();
        foreach (var item in input.itens)
        {
            abc.Add(item);
        }

        var myArray = abc.ToArray();

        dict.Add("items", myArray);
        dict.Add("test", input.test);
        dict.Add("x", input.x);

        return dict;
    }
}