using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZZBase.Lession07
{
    public class Starter : MonoBehaviour
    {
        private void OnGUI()
        {
            if (GUI.Button(new Rect(10f,10f,400f,50f), "Задание 2. Метод расширения: Количество символов в строке"))
            {
                Lession07 lession07 = new Lession07();
                lession07.Task02();
            }
            if (GUI.Button(new Rect(10f, 65f, 400f, 50f), "Задание 3а. Подсчет элементов коллекции для целых чисел"))
            {
                Lession07 lession07 = new Lession07();
                lession07.Task03a();
            }
            if (GUI.Button(new Rect(10f, 120f, 400f, 50f), "Задание 3b. Подсчет элементов коллекции (обобщенный метод)"))
            {
                Lession07 lession07 = new Lession07();
                lession07.Task03b();
            }
            if (GUI.Button(new Rect(10f, 175f, 400f, 50f), "Задание 3c. Подсчет элементов коллекции Linq"))
            {
                Lession07 lession07 = new Lession07();
                lession07.Task03c();
            }
        }
    }
}
