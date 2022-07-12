using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using UnityEngine;

public class SaveCSV : MonoBehaviour
{
    

    public void CreateXml()
    {
        XmlDocument xmlDoc = new XmlDocument(); // Xml선언
        //Xml버전, 인코딩 방식 설정
        xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "yes"));
        
        // 루트 노드 생성
        XmlNode root = xmlDoc.CreateNode(XmlNodeType.Element, "CharacterInfo", string.Empty);
        xmlDoc.AppendChild(root);
        
        // 자식 노드 생성
        XmlNode child = xmlDoc.CreateNode(XmlNodeType.Element, "Character", string.Empty);
        root.AppendChild(child);
        
        // 자식 노드에 들어갈 속성 생성
        XmlElement name = xmlDoc.CreateElement("Name");
        name.InnerText = "wergia";
        child.AppendChild(name);

        XmlElement lv = xmlDoc.CreateElement("Level");
        lv.InnerText = "1";
        child.AppendChild(lv);

        XmlElement exp = xmlDoc.CreateElement("Experience");
        exp.InnerText = "45";
        child.AppendChild(exp);
        
        xmlDoc.Save("./Assets/StreamingAssets/Character.xml");
    }
    
 
    public void WriteData(List<int> strData)
    {
        // FileMode.Create는 덮어쓰기.
        FileStream f = new FileStream(Application.dataPath + "/StreamingAssets" + "/" + "result.csv", FileMode.Create, FileAccess.Write);
 
        StreamWriter writer = new StreamWriter(f, System.Text.Encoding.Unicode);
        writer.WriteLine("Time,CarCount");
        var temp = 1;
        foreach (var i in strData)
        {
            writer.WriteLine(60*temp + "," + i);
            Debug.Log("Data Saved" + i);
            temp++;
        }
        //writer.WriteLine(strData);
        writer.Close();
    }
    
    public void WriteData_AI(List<int> strData)
    {
        // FileMode.Create는 덮어쓰기.
        FileStream f = new FileStream(Application.dataPath + "/StreamingAssets" + "/" + "result_AI.csv", FileMode.Create, FileAccess.Write);
 
        StreamWriter writer = new StreamWriter(f, System.Text.Encoding.Unicode);
        writer.WriteLine("Time,CarCount");
        var temp = 1;
        foreach (var i in strData)
        {
            writer.WriteLine(60*temp + "," + i);
            Debug.Log("Data Saved" + i);
            temp++;
        }
        //writer.WriteLine(strData);
        writer.Close();
    }
 
    
    // public void ReadData()
    // {
    //     StreamReader sr = new StreamReader(Application.dataPath + "/StreamingAssets" + "/" + "text.txt");
    //     source = sr.ReadLine();
    //     sr.Close();
    // }
}
