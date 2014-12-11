window.onload = function () {
    "use strict";

    var stage = new Kinetic.Stage({
        container: 'container',
        width: 1280,
        height: 800
    });

    var layer = new Kinetic.Layer();

    var marioImageObj = new Image();
    marioImageObj.onload = function () {
        var mario = new Kinetic.Sprite({
            x: 50,
            y: 380,
            image: marioImageObj,
            animation: 'stay',
            animations: {
                walkRight: [
                  // x, y, width, height (2 frames)
                  0, 0, 50, 150,
                  50, 0, 50, 150
                ],
                walkLeft: [
                  0, 0, 50, 150,
                  50, 0, 50, 150
                ],
                stay: [
                    0, 0, 50, 150
                ],
                jump: [
                    100, 0, 50, 150
                ]
            },
            frameRate: 7,
            frameIndex: 0
        });

        layer.add(mario);

        stage.add(layer);

        mario.start();

        var frameCount = 0;

        mario.on('frameIndexChange', function (evt) {
            if ((mario.animation() === 'walkRight' || mario.animation() === 'jump') && ++frameCount > 2 && mario.getAttr('x') < 950) {
                mario.move({
                    x: 20,
                    y: 0
                });
                mario.animation('stay');
                frameCount = 0;
            }
            if (mario.animation() === 'walkLeft' && ++frameCount > 2 && mario.getAttr('x') > 50) {
                mario.move({
                    x: -20,
                    y: 0
                });
                mario.animation('stay');
                frameCount = 0;
            }
        });

        document.body.addEventListener('keydown', function (ev) {
            if (ev.keyCode === 39) {
                mario.animation('walkRight');
                mario.scaleX(1);
            } if (ev.keyCode === 38) {
                mario.animation('jump');
            } if (ev.keyCode === 37) {
                mario.animation('walkLeft');
                mario.scaleX(-1);
            }
        }, false);

    };
    marioImageObj.src = 'images/mario1.png';

    var paper = new Raphael(0, 0, 1000, 600);

    paper.image("images/background.jpg", 0, 0, 1000, 600);
}