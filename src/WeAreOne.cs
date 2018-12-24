using PoLaKoSz.WeAreOne.DataAccessLayer.Web;
using PoLaKoSz.WeAreOne.EndPoints;

namespace PoLaKoSz.WeAreOne
{
    /// <summary>
    /// This class is the main entry point for the library.
    /// </summary>
    public class WeAreOne
    {
        /// <summary>
        /// Access the TechoBase.FM page.
        /// </summary>
        public RadioStation TechoBase { get; }

        /// <summary>
        /// Access the HouseTime.FM page.
        /// </summary>
        public RadioStation HouseTime { get; }

        /// <summary>
        /// Access the HardBase.FM page.
        /// </summary>
        public RadioStation HardBase { get; }

        /// <summary>
        /// Access the TranceBase.FM page.
        /// </summary>
        public RadioStation TranceBase { get; }

        /// <summary>
        /// Access the CoreTime.FM page.
        /// </summary>
        public RadioStation CoreTime { get; }

        /// <summary>
        /// Access the ClubTime.FM page.
        /// </summary>
        public RadioStation ClubTime { get; }

        /// <summary>
        /// Access the TeaTime.FM page.
        /// </summary>
        public RadioStation TeaTime { get; }



        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public WeAreOne()
            : this(new HttpClient()) { }

        /// <summary>
        /// Initialize a new instance with a custom <see cref="IHttpClient"/>.
        /// </summary>
        /// <param name="httpClient">Not null object to access the web.</param>
        public WeAreOne(IHttpClient httpClient)
        {
            TechoBase  = new RadioStation("technobase", httpClient);
            HouseTime  = new RadioStation("housetime",  httpClient);
            HardBase   = new RadioStation("hardbase",   httpClient);
            TranceBase = new RadioStation("trancebase", httpClient);
            CoreTime   = new RadioStation("coretime",   httpClient);
            ClubTime   = new RadioStation("clubtime",   httpClient);
            TeaTime    = new RadioStation("teatime",    httpClient);
        }
    }
}
