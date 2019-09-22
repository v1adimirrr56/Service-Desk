import { animate, animation, style } from '@angular/animations';

export const showErrorIn = animation([
  style({ height: '0' }),
  animate(
'.15s ease-in-out',
    style({ height: '12px'})
  )
]);

export const showErrorOut = animation([
  style({ height: '12px' }),
  animate(
    '.15s ease-in-out',
    style({ height: '0'})
  )
])
