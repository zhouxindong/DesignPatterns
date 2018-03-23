namespace Facade
{
    /// <summary>
    /// Provide a user interface to simply complicated system
    /// </summary>
    public class HomeTheaterFacade
    {
        private readonly Amplifier _amplifier;
        private readonly Tuner _tuner;
        private readonly DvdPlayer _dvd;
        private readonly CdPlayer _cd;
        private readonly Projector _projector;
        private readonly TheaterLights _theater_lights;
        private readonly Screen _screen;
        private readonly PopcornPopper _popper;

        public HomeTheaterFacade(
            Amplifier amplifier,
            Tuner tuner,
            DvdPlayer dvd,
            CdPlayer cd,
            Projector projector,
            Screen screen,
            TheaterLights lights,
            PopcornPopper popper)
        {
            _amplifier = amplifier;
            _tuner = tuner;
            _dvd = dvd;
            _cd = cd;
            _projector = projector;
            _screen = screen;
            _theater_lights = lights;
            _popper = popper;
        }

        public void WatchMovie(string movie)
        {

        }

        public void EndMovie()
        {

        }
    }

    public abstract class Amplifier { }
    public abstract class Tuner { }
    public abstract class DvdPlayer { }
    public abstract class CdPlayer { }
    public abstract class Projector { }
    public abstract class TheaterLights { }
    public abstract class Screen { }
    public abstract class PopcornPopper { }
}