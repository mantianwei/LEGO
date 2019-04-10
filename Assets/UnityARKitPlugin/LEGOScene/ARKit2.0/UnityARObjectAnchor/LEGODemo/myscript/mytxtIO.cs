using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.UI;
public class mytxtIO : MonoBehaviour
{
    StreamWriter writer;
    StreamReader reader;
    public Text text1;

    List<string> Allmytxt = new List<string>();
    // Use this for initialization
    void Start()
    {
//        FileInfo file = new FileInfo(Application.dataPath + "/mytxt.txt");
//        if (file.Exists)
//        {
//            file.Delete();
//            file.Refresh();
//        }
    }

    //把所有的数据写入文本中
    public void WriteIntoTxt(string message)
    {
        FileInfo file = new FileInfo(Application.persistentDataPath+"/mytxt.txt");
        //text1.text = Application.dataPath + "/mytxt.txt";
        if (!file.Exists)
        {
            writer = file.CreateText();
        }
        else
        {
            writer = file.AppendText();
        }
        writer.WriteLine(message);
        writer.Flush();
        writer.Dispose();
        writer.Close();
    }
    //读取 存储到列表中
    public void ReadOutTxt()
    {
        Allmytxt.Clear();
        reader = new StreamReader(Application.persistentDataPath + "/mytxt.txt", Encoding.UTF8);
        string text;
        while ((text = reader.ReadLine()) != null)
        {
            text1.text = text;
            Allmytxt.Add(text);
        }
        reader.Dispose();
        reader.Close();
    }

    public void ClearTxt()
    {
        FileInfo file = new FileInfo(Application.persistentDataPath + "/mytxt.txt");
        if (file.Exists)
        {
            file.Delete();
            file.Refresh();
        }
    }

    /// <summary>
    /// 获取从列表读取数据之后的List
    /// </summary>
    /// <returns></returns>
    public List<string> GetmytxtList()
    {
        ReadOutTxt();
        return Allmytxt;
    }

    /*windows下的操作
    //把所有的数据写入文本中
    public void WriteIntoTxt(string message)
    {
        FileInfo file = new FileInfo(Application.dataPath + "/mytxt.txt");
        if (!file.Exists)
        {
            writer = file.CreateText();
        }
        else
        {
            writer = file.AppendText();
        }
        writer.WriteLine(message);
        writer.Flush();
        writer.Dispose();
        writer.Close();
    }
    //windows读取 存储到列表中
    public void ReadOutTxt()
    {
        Allmytxt.Clear();
        reader = new StreamReader(Application.dataPath + "/mytxt.txt", Encoding.UTF8);
        string text;
        while ((text = reader.ReadLine()) != null)
        {
            Allmytxt.Add(text);
            Debug.Log(text);
        }
        reader.Dispose();
        reader.Close();
    }

    public void ClearTxt()
    {
        FileInfo file = new FileInfo(Application.dataPath + "/mytxt.txt");
        if (file.Exists)
        {
            file.Delete();
            file.Refresh();
        }
    }

    /// <summary>
    /// 获取从列表读取数据之后的List
    /// </summary>
    /// <returns></returns>
    public List<string> GetmytxtList()
    {
        ReadOutTxt();
        return Allmytxt;
    }

    */




}
