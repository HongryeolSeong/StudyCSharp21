using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBookApp
{
    class DataFileManager
    {
        // 텍스트 파일에서 저장된 주소록을 불러온다
        const string dataFileName = "address.dat";
        // D:\GitRepository\StudyCSharp21\chap99\AddressBookApp\AddressBookApp\bin\Debug\netcoreapp3.1

        public List<AddressInfo> ReadData() // param : List<AddressInfo>의 출력을 받아오는 변수
        {
            List<AddressInfo>/*var*/ listResult = new List<AddressInfo>();
            var filepath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터파일

            StreamReader/*var*/ sr = new StreamReader(new FileStream(filepath, FileMode.Open, FileAccess.Read)); // open
            while (sr.EndOfStream == false)
            {
                var temp = sr.ReadLine();
                // temp 데이터를 잘라서 manager.listAddress에 할당
                string[] splits = temp.Split("|"); // temp값을 항목별로 자른 배열 생성
                listResult.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });
            }
            sr.Close();

            return listResult;
        }

        public void WriteData(List<AddressInfo> list)
        {
            var filepath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터파일

            StreamWriter/*var*/ sw = new StreamWriter(new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write));
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    sw.WriteLine($"{item.Name}|{item.Phone}|{item.Address}");
                }
            }
            sw.Close();
        }
    }
}
