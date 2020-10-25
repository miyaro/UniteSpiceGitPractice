using UnityEngine;

/// <summary>
/// ゲーミングカラーをUpdateのタイミングでいい感じに返してもらえるクラス。
/// 関数のメンバ変数としてこんなかんじで定義。
///      GamingColor colorManager = new GamingColor(20/*変化させたい速度、大きいほど早い、小数指定でゆっくりとか微調整可能*/);
/// 呼び出しはUpdate内でこんな感じ
///      セットしたいcolor = colorManager.getColor(Time.deltaTime);
/// </summary>
public class GamingColor
{
    public enum ColorMode
    {
        blueUp,
        redDown,
        greenUp,
        blueDown,
        redUp,
        greenDown
    }

    ColorMode colerCountMode = ColorMode.blueUp;

    double redCount = 255;
    double blueCount = 0;
    double greenCount = 0;

    double speed = 1;
    
    // コンストラクタ
    public GamingColor():this(1){
    }

    public GamingColor(double initspeed):this(initspeed, ColorMode.blueUp){
    }

    public GamingColor(double initspeed, ColorMode startMode){
        speed =  initspeed;
        if (speed <= 0)
        {
            speed = 1;
        }
        colerCountMode = startMode;
        switch (colerCountMode)
        {
            case ColorMode.blueUp:
                redCount = 255;
                blueCount = 0;
                greenCount = 0;
                break;
            case ColorMode.redDown:
                redCount = 255;
                blueCount = 255;
                greenCount = 0;
                break;
            case ColorMode.greenUp:
                redCount = 0;
                blueCount = 255;
                greenCount = 0;
                break;
            case ColorMode.blueDown:
                redCount = 0;
                blueCount = 255;
                greenCount = 255;
                break;
            case ColorMode.redUp:
                redCount = 0;
                blueCount = 0;
                greenCount = 255;
                break;
            case ColorMode.greenDown:
                redCount = 255;
                blueCount = 0;
                greenCount = 255;
                break;
        }
    }


    public Color32 getColor(float deltaTime)
    {
        if(deltaTime <= 0)
        {
            deltaTime = 1.0f / 255.0f;
        }
        switch (colerCountMode)
        {
            case ColorMode.blueUp:
                blueCount += (255 * deltaTime) * speed;
                if (blueCount >= 255)
                {
                    blueCount = 255;
                    colerCountMode = ColorMode.redDown;
                }
                break;
            case ColorMode.redDown:
                redCount -= (255 * deltaTime) * speed;
                if (redCount <= 0)
                {
                    redCount = 0;
                    colerCountMode = ColorMode.greenUp;
                }
                break;
            case ColorMode.greenUp:
                greenCount += (255 * deltaTime) * speed;
                if (greenCount >= 255)
                {
                    greenCount = 255;
                    colerCountMode = ColorMode.blueDown;
                }
                break;
            case ColorMode.blueDown:
                blueCount -= (255 * deltaTime) * speed;
                if (blueCount <= 0)
                {
                    blueCount = 0;
                colerCountMode = ColorMode.redUp;
                }
                break;
            case ColorMode.redUp:
                redCount += (255 * deltaTime) * speed;
                if (redCount >= 255)
                {
                    redCount = 255;
                    colerCountMode = ColorMode.greenDown;
                }
                break;
            case ColorMode.greenDown:
                greenCount -= (255 * deltaTime) * speed;
                if (greenCount <= 0)
                {
                    greenCount = 0;
                    colerCountMode = ColorMode.blueUp;
                }
                break;
        }

        return new Color32((byte)redCount, (byte)greenCount, (byte)blueCount, 255);
    }
}
