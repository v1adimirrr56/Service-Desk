import { animate, AnimationMetadata, state, style, transition, trigger } from '@angular/animations';

export const FOCUS_ANIMATION_TIMING = '0.2s ease-in-out';

export const focusFormLabelAnimation: AnimationMetadata[] = [
  animate(
    FOCUS_ANIMATION_TIMING,
    style({
      transform: 'translateY(-18px) scale(0.8)',
      color: '#8e44ac'
    })
  )
];

export const focusoutFormLabelAnimation: AnimationMetadata[] = [
  animate(
    FOCUS_ANIMATION_TIMING,
    style({
      color: '#757575',
      transform: 'none'
    })
  )
];

export const filledFocusFormLabelAnimation: AnimationMetadata[] = [
  animate(
    FOCUS_ANIMATION_TIMING,
    style({
      color: '#8e44ac'
    })
  )
];

export const filledFocusoutFormLabelAnimation: AnimationMetadata[] = [
  animate(
    FOCUS_ANIMATION_TIMING,
    style({
      color: '#757575',
    })
  )
];
