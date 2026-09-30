package com.example.mobilna;

import android.annotation.SuppressLint;

import android.os.Bundle;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.Random;

public class MainActivity extends AppCompatActivity {

    public static int instancesCount = 0;
    class Kosc
    {
        public Kosc()
        {
            Random rand = new Random();
            int number = rand.nextInt(6) + 1;

            value = number;
            imageIndex = number;
            available = true;
            instancesCount++;
        }

        public Kosc(int v)
        {
            if (v < 1 || v > 6)
                value = 0;
            else
                value = v;

            imageIndex = v;
            available = true;
            instancesCount++;
        }

        public void Rzuc()
        {
            Random rand = new Random();
            int number = rand.nextInt(6) + 1;

            value = number;
            imageIndex = number;
        }

        public void Disable()
        {
            available = false;
        }

        public String GetValueToString()
        {
            switch(value)
            {
                case 0:
                    return "zero";
                case 1:
                    return "jeden";
                case 2:
                    return "dwa";
                case 3:
                    return "trzy";
                case 4:
                    return "cztery";
                case 5:
                    return "pięć";
                case 6:
                    return "sześć";
            }

            return "zła wartość";
        }

        public String[] images = { "kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png"   };
        public int value = 0;
        public int imageIndex = 0;
        public boolean available = false;
    }

    public void Rzut()
    {
        int score = 0;

        for (int i = 0; i < kosci.length; i++)
        {
            if(!kosci[i].available)
            {
                score += kosci[i].value;
                continue;
            }

            kosci[i].Rzuc();
            diceImages[i].setImageResource(getResources().getIdentifier("kosc" + (kosci[i].value), "drawable", getPackageName()));
            score += kosci[i].value;
        }

        TextView textView = findViewById(R.id.textView);
        textView.setText("" + score);
    }

    ImageView[] diceImages;
    public Kosc[] kosci = new Kosc[] {
            new Kosc(),
            new Kosc(),
            new Kosc(),
            new Kosc(),
            new Kosc(),
    };

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        Button buttonNext = findViewById(R.id.rzutBtn);
        buttonNext.setOnClickListener(v -> Rzut());

        diceImages = new ImageView[]{
                findViewById(R.id.dice1),
                findViewById(R.id.dice2),
                findViewById(R.id.dice3),
                findViewById(R.id.dice4),
                findViewById(R.id.dice5)
        };

        for (int i = 0; i < diceImages.length; i++) {
            ImageView image = diceImages[i];
            int finalI = i;
            image.setOnClickListener(v -> {
                kosci[finalI].available = !kosci[finalI].available;
                boolean available = kosci[finalI].available;

                float newAlpha = available ? 1.0f : 0.5f;
                image.setAlpha(newAlpha);
            });
        }

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }
}