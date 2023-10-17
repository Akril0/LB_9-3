using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_9_3
{
    public class Node
    {
        public String[] Data; // Данные в узле
        public Node Left; // Ссылка на левого потомка
        public Node Right; // Ссылка на правого потомка

        public static Node Insert(Node root, String[] value)
        {
            if (root == null) // Если дерево пусто
            {
                root = new Node(); // Создаем новый узел
                root.Data = value; // Добавляем данные в узел
                root.Left = null; // Левый потомок пуст
                root.Right = null; // Правый потомок пуст
            }
            else if (value[0].Length <= root.Data[0].Length) // Если значение меньше значения корня
            {
                root.Left = Insert(root.Left, value); // Рекурсивно добавляем в левое поддерево
            }
            else // Если значение больше или равно значению корня
            {
                root.Right = Insert(root.Right, value); // Рекурсивно добавляем в правое поддерево
            }
            return root; // Возвращаем корень дерева
        }
    }
}
