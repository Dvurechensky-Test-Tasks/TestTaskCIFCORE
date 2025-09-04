/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 сентября 2025 08:07:37
 * Version: 1.0.13
 */

using ModestTree;

namespace Zenject.Asteroids
{
    public enum ShipStates
    {
        Moving,
        Dead,
        WaitingToStart,
        Count
    }

    public class ShipStateFactory
    {
        readonly ShipStateWaitingToStart.Factory _waitingFactory;
        readonly ShipStateMoving.Factory _movingFactory;
        readonly ShipStateDead.Factory _deadFactory;

        public ShipStateFactory(
            ShipStateDead.Factory deadFactory,
            ShipStateMoving.Factory movingFactory,
            ShipStateWaitingToStart.Factory  waitingFactory)
        {
            _waitingFactory = waitingFactory;
            _movingFactory = movingFactory;
            _deadFactory = deadFactory;
        }

        public ShipState CreateState(ShipStates state)
        {
            switch (state)
            {
                case ShipStates.Dead:
                {
                    return _deadFactory.Create();
                }
                case ShipStates.WaitingToStart:
                {
                    return _waitingFactory.Create();
                }
                case ShipStates.Moving:
                {
                    return _movingFactory.Create();
                }
            }

            throw Assert.CreateException();
        }
    }
}
