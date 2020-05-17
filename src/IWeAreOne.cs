using PoLaKoSz.WeAreOne.EndPoints;

namespace PoLaKoSz.WeAreOne
{
    /// <summary>
    /// Provides access to the whole library.
    /// </summary>
    public interface IWeAreOne
    {
        /// <summary>
        /// Access the TechoBase.FM page.
        /// </summary>
        IRadioStation TechoBase { get; }

        /// <summary>
        /// Access the HouseTime.FM page.
        /// </summary>
        IRadioStation HouseTime { get; }

        /// <summary>
        /// Access the HardBase.FM page.
        /// </summary>
        IRadioStation HardBase { get; }

        /// <summary>
        /// Access the TranceBase.FM page.
        /// </summary>
        IRadioStation TranceBase { get; }

        /// <summary>
        /// Access the CoreTime.FM page.
        /// </summary>
        IRadioStation CoreTime { get; }

        /// <summary>
        /// Access the ClubTime.FM page.
        /// </summary>
        IRadioStation ClubTime { get; }

        /// <summary>
        /// Access the TeaTime.FM page.
        /// </summary>
        IRadioStation TeaTime { get; }
    }
}
