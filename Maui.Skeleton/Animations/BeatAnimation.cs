﻿using System.Threading.Tasks;

namespace Maui.Skeleton.Animations
{
    public class BeatAnimation : BaseAnimation
    {
        public BeatAnimation(int interval, double? parameter)
        {
            this.Interval = (uint)interval;
            this.Parameter = parameter.HasValue ? parameter.Value : 1.03;
        }

        protected override async Task<bool> Animate(BindableObject bindable)
        {
            var self = (View)bindable;
            await self.ScaleTo(this.Parameter, this.Interval);
            await self.ScaleTo(1, this.Interval);
            return true;
        }

        protected override async Task StopAnimation(BindableObject bindable)
        {
            var self = (View)bindable;
            await self.ScaleTo(1, 100);
        }
    }
}