import { animate, state, style, transition, trigger } from '@angular/animations';

export const focusBlurFormLabel = () => {
  return trigger('focusBlurFormLabel', [
    state('fillUp', style({
      transform: 'translateY(-18px) scale(0.8)'
    })),
    state('focus', style({
      transform: 'translateY(-18px) scale(0.8)',
      color: '#8e44ac'
    })),
    state('blur', style({
    })),
    transition('blur <=> focus', [
      animate('0.2s ease-in-out')
    ]),
    transition('* => fillUp', [
    ]),
  ]);
};
