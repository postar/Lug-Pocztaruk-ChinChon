namespace BEL
{
    public class CyclicList <GenericType>
    {
        private GenericType[] content;
        private int currentIndex;
        public CyclicList(params GenericType[] values)
        {
            content = values;
            currentIndex = 0;
        }
        public GenericType Current() 
        { 
            return content[currentIndex];
        }
        public void Next()
        {
            currentIndex = (currentIndex + 1) % content.Length;
        }
    }
}