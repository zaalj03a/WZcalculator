using ABB.Robotics.RobotStudio.Stations;

namespace WZcalculator.Interfaces
{
    public interface IZone
    {
        /// <summary>
        /// Returns the zone type associated with this instance.
        /// </summary>
        /// <returns></returns>
        ZoneType GetZoneType();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>A struct containing the dimensions for this type of temporary graphic.</returns>
        object GetDimensions();

        /// <summary>
        /// Set the dimensions of the temporary graphic associated with this instance.
        /// </summary>
        /// <param name="dimensions">A struct containing the dimensions</param>
        void SetDimensions(object dimensions);

        /// <summary>
        /// Draws a temporary graphic that is aligned to the base frame of the mechanical unit.
        /// </summary>
        void DrawZone(RsMechanicalUnit mechanicalUnit);

        /// <summary>
        /// Create the zone in RAPID syntax. 
        /// </summary>
        /// <param name="mechanicalUnit">The robot from which the zone is calculated.</param>
        string CreateRapidZone(RsMechanicalUnit mechanicalUnit);

        /// <summary>
        /// Deletes the temporary graphic associated with this instance.
        /// </summary>
        void DeleteZone();
    }
}
