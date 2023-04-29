using System.Diagnostics;
using System.Drawing;
using System.Reflection;

namespace LinkedLists.Logic
{
    public class DoubleList<T>
    {
        private DoubleNode<T>? _first;

        private DoubleNode<T>? _last;

        public DoubleList()
        {
            _first = null;
            _last = null;
            Count = 0;
        }

        public int Count { get; set; }

        public bool IsEmpty => Count == 0;

        public override string ToString()
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null)
            {
                output += $"{pointer.Data}\n";
                pointer = pointer.Right;
            }
            return output;
        }

        public string ToInvertedList()
        {
            var output = string.Empty;
            var pointer = _last;
            while (pointer != null)
            {
                output += $"{pointer.Data}\n";
                pointer = pointer.Left;
            }
            return output;
        }

        public void Add(T item)
        {
            var node = new DoubleNode<T>(item);
            if (IsEmpty)
            {
                _first = node;
                _last = node;
            }
            else
            {
                node.Left = _last;
                _last!.Right = node;
                _last = node;
            }
            Count++;
        }

        public T[] ToArray()
        {
            var array = new T[Count];
            int i = 0;
            var pointer = _first;
            while (pointer != null)
            {
                array[i] = pointer.Data!;
                i++;
                pointer = pointer.Right;
            }
            return array;
        }

        public Response Delete(T item)
        {
            var pointer = _first;
            while (pointer != null)
            {
                if (item!.Equals(pointer.Data))
                {
                    if (pointer == _first)
                    {
                        pointer.Right!.Left = null;
                        _first = pointer.Right;
                    }
                    else if (pointer == _last)
                    {
                        pointer.Left!.Right = null;
                        _last = pointer.Left;
                    }
                    else
                    {
                        pointer.Left!.Right = pointer.Right;
                        pointer.Right!.Left = pointer.Left;
                    }
                    pointer = null;
                    Count--;
                    return new Response
                    {
                        IsScucced = true,
                        Message = $"The element: {item} was deleted."
                    };
                }
                pointer = pointer!.Right;
            }
            return new Response
            {
                IsScucced = false,
                Message = $"The element: {item} not found."
            };
        }

        public Response Insert(T item, int position)
        {
            if (position < 0 || position >= Count)
            {
                return new Response
                {
                    IsScucced = false,
                    Message = $"The position {position} is not valid."
                };
            }
            var node = new DoubleNode<T>(item);
            if (position == 0)
            {
                _first!.Left = node;
                node.Right = _first;
                _first = node;
            }
            else
            {
                int i = 1;
                var pointer = _first!.Right;
                while (i < position)
                {
                    pointer = pointer!.Right;
                    i++;
                }
                pointer!.Left!.Right = node;
                node.Left = pointer.Left;
                node.Right = pointer;
                pointer.Left = node;
            }

            Count++;
            return new Response
            {
                IsScucced = true,
                Message = $"The item {item} was inserted."
            };

        }

        //Returns the cars of a brand
        public string GetBrand(string brand)
        {
            var pointer = _first;
            var output = string.Empty;
            while (pointer != null)
            {
                Automovil auto = (Automovil)Convert.ChangeType(pointer.Data, typeof(Automovil))!;
                if (auto!.Brand!.Equals(brand))
                {
                    output += $"{auto}\n";
                }
                pointer = pointer.Right;
            }
            return output + "\n";
        }

        //Returns the cars in a range of years
        public string GetYear(int lower, int upper)
        {
            var pointer = _first;
            var output = string.Empty;
            while (pointer != null)
            {
                Automovil auto = (Automovil)Convert.ChangeType(pointer.Data, typeof(Automovil))!;
                if (auto!.Year!>= lower && auto!.Year! <= upper)
                {
                    output += $"{auto}\n";
                }
                pointer = pointer.Right;
            }
            return output + "\n";
        }

        public string GetSeveralFilters(string brand, string model, string color, int minimunYear, decimal maximunPrice)
        {
            var pointer = _first;
            var output = string.Empty;
            while (pointer != null)
            {
                Automovil auto = (Automovil)Convert.ChangeType(pointer.Data, typeof(Automovil))!;
                if (auto!.Brand!.Equals(brand) && auto!.Model!.Equals(model) && auto!.Color!.Equals(color)
                    && auto!.Year! >= minimunYear && auto!.Price! <= maximunPrice)
                {
                    output += $"{auto}\n";
                }
                pointer = pointer.Right;
            }
            return output + "\n";
        }


    }
}
