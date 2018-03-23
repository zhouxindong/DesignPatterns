using System;
using System.Collections.Generic;

namespace FSM
{
    /// <summary>
    /// States for Turnstile
    /// </summary>
    public enum eTurnstileState
    {
        Locked,
        Unlocked
    }

    /// <summary>
    /// Events for Turnstile
    /// </summary>
    public enum eTurnstileEvent
    {
        Coin,
        Pass
    }

    /// <summary>
    /// 状态迁移表项
    /// </summary>
    internal class Transition
    {
        public eTurnstileState StartState { get; private set; }
        public eTurnstileState EndState { get; private set; }
        public eTurnstileEvent EventTrigger { get; private set; }
        public Action Action { get; private set; }

        public Transition(eTurnstileState start_state,
                          eTurnstileState end_state,
                          eTurnstileEvent event_trigger,
                          Action action)
        {
            StartState = start_state;
            EndState = end_state;
            EventTrigger = event_trigger;
            Action = action;
        }
    }

    /// <summary>
    /// 旋转门
    /// </summary>
    public class Turnstile
    {
        public eTurnstileState State { get; set; }

        private readonly IList<Transition> _transitions = new List<Transition>();

        public Turnstile(ITurnstileController controller)
        {
            // 构建状态迁移表
            Action unlock = controller.Unlock;
            Action alarm = controller.Alarm;
            Action thankyou = controller.Thankyou;
            Action lock_action = controller.Lock;

            AddTransition(eTurnstileState.Locked, eTurnstileState.Unlocked, eTurnstileEvent.Coin, unlock);
            AddTransition(eTurnstileState.Locked, eTurnstileState.Locked, eTurnstileEvent.Pass, alarm);
            AddTransition(eTurnstileState.Unlocked, eTurnstileState.Unlocked, eTurnstileEvent.Coin, thankyou);
            AddTransition(eTurnstileState.Unlocked, eTurnstileState.Locked, eTurnstileEvent.Pass, lock_action);

            State = eTurnstileState.Locked;
        }

        private void AddTransition(eTurnstileState start, eTurnstileState end,
                                   eTurnstileEvent e, Action action)
        {
            _transitions.Add(new Transition(start, end, e, action));
        }

        /// <summary>
        /// 状态事件解释引擎
        /// </summary>
        /// <param name="e"></param>
        public void HandleEvent(eTurnstileEvent e)
        {
            foreach (var transition in _transitions)
            {
                if (State == transition.StartState &&
                    e == transition.EventTrigger)
                {
                    transition.Action();
                    State = transition.EndState;
                }
            }
        }
    }
}