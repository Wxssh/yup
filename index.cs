div {
  --h: 303;
  border: 3vmin double hsl(var(--h), 100%, 50%);
  border-radius: 2.5vmin;
  margin: 2.5vmin;
  min-height: 15vmin;
  min-width: 15vmin;
  max-width: 100vmin;
  transform-style: preserve-3d;
  --prefix-transform: scale(0.75);

  animation: spinner 60000ms calc(var(--i) * -7200ms - 2000ms) infinite
    alternate ease-in-out backwards;
  animation-play-state: paused;

  background: radial-gradient(
    circle,
    hsl(var(--h) 100% 50% / 0),
    hsl(var(--h) 100% 50% / 0),
    hsl(var(--h) 100% 50% / 0.5)
  );
}

@keyframes spinner {
  0% {
    transform: var(--prefix-transform) rotateZ(0.25turn) rotateX(0turn);
  }
  100% {
    transform: var(--prefix-transform) rotateZ(0.25turn) rotateX(10turn);
  }
}

div > div {
  --prefix-transform: ;
  --h: 343;
}
div > div > div {
  --h: 23;
}
div > div > div > div {
  --h: 43;
}
div > div > div > div > div {
  --h: 103;
}
div > div > div > div > div > div {
  --h: 183;
}

@media all and (prefers-reduced-motion: no-preference) {
  div {
    animation-delay: calc(var(--i) * 1000ms);
    animation-play-state: running;
  }
  /**/
  div > div::before,
  div > div::after {
    background: hsl(var(--h, 303), 100%, 50%);
    content: "";
    position: absolute;
    left: 0;
    width: 2.5vmin;
    height: 0.5vmin;
    top: 50%;
    transform: translate(-5.5vmin, -50%);
  }
  div > div::after {
    left: initial;
    right: 0;
    transform: translate(5.5vmin, -50%);
  }
  /**/
}

body {
  height: 100vh;
  display: flex;
  justify-content: center;
  align-items: center;
  perspective: 100vmin;
  overflow: hidden;
  background: #16162c;
}

* {
  margin: 0;
  box-sizing: border-box;
  position: relative;
}
