﻿using System;
using System.IO;

public class HotelScene : IScene
{
    IScene nextScene = new RelaxScene();
    public IScene GetNextScene()
    {
        return nextScene;
    }

    public void OnShow()
    {
        AsciiArt.Draw($"img\\Hotel.jpg", 90);

        Console.WriteLine("\n여관에서 무엇을 할까?");
        Console.Write("1. ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("쉬기");
        Console.ResetColor();

        Console.Write("2. ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("용병");
        Console.ResetColor();
        Console.WriteLine("고용");
        Console.WriteLine("3. 대화하기");
        Console.WriteLine("4. 나가기");
        
        while(true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.KeyChar == '1')
            {
                nextScene = new RelaxScene();
                break;
            }
            else if(keyInfo.KeyChar == '2')
            {
                nextScene = new HireMercenariesScene();
                break;
            }
            else if (keyInfo.KeyChar == '3')
            {
                nextScene = new NpcScene();
                break;
            }
            else if (keyInfo.KeyChar == '4')
            {
                nextScene = new SpartaTownScene();
                break;
            }
        }
    }
}