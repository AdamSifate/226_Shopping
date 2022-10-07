namespace Shopping
{
    public class Article
    {
        #region private attributes
        private float _price = 0f;
        #endregion private attributes

        #region public methods
        public Article(float price)
        {
            _price = price;
        }
        public float Price
        {
            get
            {
                //asd
                return _price;
            }
        }
        #endregion public methods
    }
}
