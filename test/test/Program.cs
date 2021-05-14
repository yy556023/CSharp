using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace what_A_and_B
{
	class Program
	{
		static void Main(string[] args)
		{
			// -----變數宣告-----
			int count;
			int temp;
			// 存放答題歷史
			Dictionary<string, string> AnserDic = new Dictionary<string, string>();
			// 幾A幾B
			int A = 0;
			int B = 0;
			// -----變數宣告-----

			// 隨機4個數字不重複0~9
			// -----亂數-----
			Random rad = new Random();
			// 亂數產生
			string str = "";
			
			while (str.Length < 4) 
			{
				temp = rad.Next(0, 10);
				// 若字串內沒有重複的數字，在加入一個新的數字字串
				str += (str.Contains(temp.ToString())) ? null : temp.ToString();
			}
			// -----亂數-----

			// -----test-----
			// 顯示答案
			//Console.WriteLine(str);
			// -----test-----

			// -----遊戲迴圈-----
			count = 0;
			while (A != 4)
			{
				try
				{
					// try開始

					// A和B的變數宣告
					A = 0;
					B = 0;
					// 使用者輸入
					Console.Write("四位數字：");
					string userInput = Console.ReadLine();

					// -----判斷使用者輸入的格式是否正確-----

					// 若使用者輸入的不完全是數字 > 報錯
					Convert.ToInt32(userInput);

					// 使用者輸入字數小於題目字數 > 報錯
					if(userInput.Length != str.Length) throw new Exception();

					// 若使用者輸入到重複的數字 > 報錯
					for (int i = 0; i < userInput.Length; i++)
					{
						for (int j = i + 1; j < userInput.Length; j++)
						{
							if (userInput[i] == userInput[j])
							{
								throw new Exception();
							}
						}
					}

					// 若使用者輸之前答過的數字 > 報錯
                    foreach (var item in AnserDic.Keys)
                    {
						if(item == userInput)
                        {
							throw new Exception();
                        }
                    }

                    // -----判斷使用者輸入的格式是否正確-----
					

					// -----判斷使用者輸入的答案是否正確-----
					// 位置錯數字對 = B
					// 位置對數字對 = A
					for (int i = 0; i < userInput.Length; i++)
					{

						// 數字對
						if (str.Contains(userInput[i]))
							//數字對位置對

							if (str[i] == userInput[i]) A++;

							//數字對位置錯
							else B++;
					}

					// 顯示幾A幾B
					Console.WriteLine($"{A}A{B}B\n");
					AnserDic.Add(userInput, $"{A}A{B}B");

					// -----判斷使用者輸入的答案是否正確-----
					Console.Clear();
					Console.WriteLine("===答題歷史===");
					foreach (var item in AnserDic)
					{
						Console.WriteLine($"{item.Key} {item.Value}");
					}
					count++;

					// try結束
				}
				catch (Exception error)
				{
					Console.WriteLine("輸入錯誤，請重新輸入\n");
				}
				
			}
			Console.WriteLine($"恭喜你答對了!! 答題次數 {count} 次");
			
            // -----遊戲迴圈-----

        }
	}
}
