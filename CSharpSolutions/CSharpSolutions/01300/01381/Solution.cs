namespace CSharpSolutions._01300._01381
{
    public class CustomStack
    {

        private int _maxSize;
        private int _head;
        private int[] _data;
        public CustomStack(int maxSize)
        {
            _maxSize = maxSize;
            _data = new int[_maxSize];
            _head = 0;
        }

        public void Push(int x)
        {
            if (_head == _maxSize) return;
            _data[_head] = x;
            _head++;
        }

        public int Pop()
        {
            if (_head == 0) return -1;
            _head--;
            return _data[_head];
        }

        public void Increment(int k, int val)
        {
            for (int i = 0; i < k && i < _head; i++)
                _data[i] += val;
        }
    }
    /**
     * Your CustomStack object will be instantiated and called as such:
     * CustomStack obj = new CustomStack(maxSize);
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * obj.Increment(k,val);
     */
}
