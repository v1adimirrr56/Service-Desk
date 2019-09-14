import { animate, AnimationMetadata, style } from '@angular/animations';

export const FOCUS_ANIMATION_TIMING = '0.15s ease-in-out';

export const formFieldInputfocusAnimation: AnimationMetadata[] = [
  animate(
    FOCUS_ANIMATION_TIMING,
    style({
      borderBottom: '1px solid #8e44ac',
      boxShadow: '0 1px 0 0 #8e44ac'
    })
  )
];

export const formFieldInputfocusoutAnimation: AnimationMetadata[] = [
  animate(
    FOCUS_ANIMATION_TIMING,
    style({
      borderBottom: '1px solid #d9d9d9',
      boxShadow: 'none'
    })
  )
];
