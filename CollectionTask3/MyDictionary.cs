using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace MyDictionary
{
         /*
         * �������������� Visual Studio, ������� ������ �� �������� Console Application.

            ������� �������� MyDictionary <TKey, TValue>. 
            ��������� � ������������ ��������� ���������
            ������������ �� ��������� ��������� ��������� 
            ����� Dictionary <TKey, TValue>. ̳�������
            ���������� ��������� �����䳿 � �����������, ������� �������� 
            ����� ��������� ��������,   
            ���������� ��� ��������� �������� �������� �� �������� ������� 
            � ���������� ����� ��� ������� ��� ��������� �������� ������� ��������. 
            ��������� ��������� �������� �������� �������� � ���� foreach.
         */
        class MyDictionary<TKey, TValue> : IEnumerable where TKey : IComparable<TKey> where TValue : class
        {
            private TKey[] keys;
            private TValue[] values;
            private int maxSize = 10;
            private int size = 0;
            public MyDictionary()
            {
                keys = new TKey[maxSize];
                values = new TValue[maxSize];
            }

            public void Add(TKey key, TValue value)
            {
                if (size == maxSize)
                {
                    throw new Exception("���������� ������������ �����");
                }
                if (keys.Contains(key))
                {
                    throw (new Exception("��� � ����� ����"));
                }
                keys[size] = key;
                values[size] = value;
                size++;
            }

            public TValue this[TKey key]
            {
                get
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (keys[i].Equals(key))
                            return values[i];
                    }
                    return null;
                    //throw new Exception("�� ��������");
                }
            }

            public int Count { get { return size; } }

            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < size; i++)
                {
                    yield return values[i];
                }
                yield break;
            }
        }

}
