import { animate, state, style, transition, trigger } from '@angular/animations';

export const focusBlurFormInput = () => {
  return trigger('focusBlurFormInput', [
    state('focus', style({
      borderBottom: '1px solid #8e44ac',
      boxShadow: '0 1px 0 0 #8e44ac'
    })),
    state('blur', style({
      borderBottom: '1px solid #d9d9d9',
      boxShadow: 'none'
    })),
    transition('blur <=> focus', [
      animate('0.15s ease-in-out')
    ]),
  ]);
};
