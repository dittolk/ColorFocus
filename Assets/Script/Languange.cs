using UnityEngine;

public class Languange : MonoBehaviour {

    public static int selected_languange;

    public void SelectLanguange(int ln)
    {
        selected_languange = ln;

        if(selected_languange == 0) //english
        {
            /* Button and UI */
            LanguangeLibrary.play = "Play";
            LanguangeLibrary.high_score = "Brain Level";
            LanguangeLibrary.live_high_score = "Best Score : ";
            LanguangeLibrary.score = "Score : ";
            LanguangeLibrary.exit = "Exit";
            LanguangeLibrary.back = "Back";
            LanguangeLibrary.share = "Share";
            LanguangeLibrary.about = "About";
            LanguangeLibrary.play_again = "Play Again";
            LanguangeLibrary.menu = "Menu";
            LanguangeLibrary.game_over = "Game Over";
            LanguangeLibrary.rate_us = "Rate Us";
            LanguangeLibrary.like_us = "Like Us";
            LanguangeLibrary.how_to_play = "How To Play";
            LanguangeLibrary.description = "Just select the right color, and don't be fooled by the words!";
            LanguangeLibrary.title_menu = "COLOR FOCUS";
            LanguangeLibrary.normal_mode = "Normal";
            LanguangeLibrary.inverted_mode = "Inverted";
            LanguangeLibrary.select_mode = "Select Mode";

            /*Gameplay color*/
            LanguangeLibrary.red_text = "RED";
            LanguangeLibrary.blue_text = "BLUE";
            LanguangeLibrary.cyan_text = "CYAN";
            LanguangeLibrary.orange_text = "ORANGE";
            LanguangeLibrary.green_text = "GREEN";
            LanguangeLibrary.black_text = "BLACK";
            LanguangeLibrary.brown_text = "BROWN";
            LanguangeLibrary.yellow_text = "YELLOW";
            LanguangeLibrary.magenta_text = "MAGENTA";
            LanguangeLibrary.purple_text = "PURPLE";

        }

        else if (selected_languange == 1)    //indonesian
        {
            /* Button and UI */
            LanguangeLibrary.play = "Mulai";
            LanguangeLibrary.high_score = "Level Otak";
            LanguangeLibrary.live_high_score = "Skor Tertinggi : ";
            LanguangeLibrary.score = "Skor : ";
            LanguangeLibrary.exit = "Keluar";
            LanguangeLibrary.back = "Kembali";
            LanguangeLibrary.share = "Bagikan";
            LanguangeLibrary.about = "Tentang Developer";
            LanguangeLibrary.play_again = "Main Lagi";
            LanguangeLibrary.menu = "Menu";
            LanguangeLibrary.game_over = "Game Over";
            LanguangeLibrary.rate_us = "Beri Rating";
            LanguangeLibrary.like_us = "Like Kami";
            LanguangeLibrary.how_to_play = "Cara Bermain";
            LanguangeLibrary.description = "Pilih warna yang sesuai dengan teks dan warna teks";
            LanguangeLibrary.title_menu = "COLOR FOCUS";
            LanguangeLibrary.normal_mode = "Normal";
            LanguangeLibrary.inverted_mode = "Terbalik";
            LanguangeLibrary.select_mode = "Pilih Mode";

            /*Gameplay color*/
            LanguangeLibrary.red_text = "MERAH";
            LanguangeLibrary.blue_text = "BIRU";
            LanguangeLibrary.cyan_text = "CYAN";
            LanguangeLibrary.orange_text = "ORANYE";
            LanguangeLibrary.green_text = "HIJAU";
            LanguangeLibrary.black_text = "HITAM";
            LanguangeLibrary.brown_text = "COKLAT";
            LanguangeLibrary.yellow_text = "KUNING";
            LanguangeLibrary.magenta_text = "MAGENTA";
            LanguangeLibrary.purple_text = "UNGU";

            LanguangeLibrary.status_bahasa = 1;
        }

        else if (selected_languange == 2)   //japanese
        {
            /* Button and UI */
            LanguangeLibrary.play = "プレー";
            LanguangeLibrary.high_score = "脳内レベル";
            LanguangeLibrary.live_high_score = "最高のスコア : ";
            LanguangeLibrary.score = "スコア : ";
            LanguangeLibrary.exit = "出口";
            LanguangeLibrary.back = "バック";
            LanguangeLibrary.share = "シェア";
            LanguangeLibrary.about = "およそ";
            LanguangeLibrary.play_again = "再びプレー";
            LanguangeLibrary.menu = "メニュー";
            LanguangeLibrary.game_over = "ゲームオバ";
            LanguangeLibrary.rate_us = "レート";
            LanguangeLibrary.like_us = "ライク";
            LanguangeLibrary.how_to_play = "遊び方";
            LanguangeLibrary.title_menu = "COLOR FOCUS";
            LanguangeLibrary.normal_mode = "ノーマル";
            LanguangeLibrary.inverted_mode = "反転しました";
            LanguangeLibrary.select_mode = "モード";

            /*Gameplay color*/
            LanguangeLibrary.red_text = "あか";
            LanguangeLibrary.blue_text = "あお";
            LanguangeLibrary.cyan_text = "シアン";
            LanguangeLibrary.orange_text = "オレンジ";
            LanguangeLibrary.green_text = "みどり";
            LanguangeLibrary.black_text = "くろ";
            LanguangeLibrary.brown_text = "ちゃいろ";
            LanguangeLibrary.yellow_text = "きいろ";
            LanguangeLibrary.magenta_text = "マゼンタ";
            LanguangeLibrary.purple_text = "むらさき";
            LanguangeLibrary.description = "ちゅうしんにとどめそしてちゃくしょくされていないテキストのいろをしんちょうにえらんでください";

            /* for other options */
            LanguangeLibrary.status_bahasa = 2;
        }
        else if (selected_languange == 3)   //french
        {
            /* Button and UI */
            LanguangeLibrary.play = "Jouer";
            LanguangeLibrary.high_score = "Niveau du cerveau";
            LanguangeLibrary.live_high_score = "Meilleur score : ";
            LanguangeLibrary.score = "Score : ";
            LanguangeLibrary.exit = "Sortie";
            LanguangeLibrary.back = "Arrière";
            LanguangeLibrary.share = "Partager";
            LanguangeLibrary.about = "Environ";
            LanguangeLibrary.play_again = "Rejouer";
            LanguangeLibrary.menu = "Menu";
            LanguangeLibrary.game_over = "Jeu terminé";
            LanguangeLibrary.rate_us = "Évaluer";
            LanguangeLibrary.like_us = "Aimer";
            LanguangeLibrary.how_to_play = "Comment jouer";
            LanguangeLibrary.title_menu = "COLOR FOCUS";
            LanguangeLibrary.normal_mode = "Normal";
            LanguangeLibrary.inverted_mode = "Inverti";
            LanguangeLibrary.select_mode = "Sélectionnez le mode";

            /*Gameplay color*/
            LanguangeLibrary.red_text = "ROUGE";
            LanguangeLibrary.blue_text = "BLEU";
            LanguangeLibrary.cyan_text = "BLEU CIEL";
            LanguangeLibrary.orange_text = "ORANGE";
            LanguangeLibrary.green_text = "VERT";
            LanguangeLibrary.black_text = "NOIR";
            LanguangeLibrary.brown_text = "BRUN";
            LanguangeLibrary.yellow_text = "JAUNE";
            LanguangeLibrary.magenta_text = "ROSE";
            LanguangeLibrary.purple_text = "POURPRE";
            LanguangeLibrary.description = "Il suffit de sélectionner la bonne couleur, et ne vous laissez pas berner par les mots!";

            /* for other options */
            LanguangeLibrary.status_bahasa = 3;
        }
        else if (selected_languange == 4)   //korean
        {
            /* Button and UI */
            LanguangeLibrary.play = "놀다";
            LanguangeLibrary.high_score = "두뇌 수준";
            LanguangeLibrary.live_high_score = "최고 점수 : ";
            LanguangeLibrary.score = "점수 : ";
            LanguangeLibrary.exit = "출구";
            LanguangeLibrary.back = "뒤로";
            LanguangeLibrary.share = "몫";
            LanguangeLibrary.about = "약";
            LanguangeLibrary.play_again = "다시 재생";
            LanguangeLibrary.menu = "메뉴";
            LanguangeLibrary.game_over = "게임 끝";
            LanguangeLibrary.rate_us = "율";
            LanguangeLibrary.like_us = "좋다";
            LanguangeLibrary.how_to_play = "게임 방법";
            LanguangeLibrary.title_menu = "COLOR FOCUS";
            LanguangeLibrary.normal_mode = "표준";
            LanguangeLibrary.inverted_mode = "성욕 도착의";
            LanguangeLibrary.select_mode = "선택 모드";

            /*Gameplay color*/
            LanguangeLibrary.red_text = "빨간색";
            LanguangeLibrary.blue_text = "파란색";
            LanguangeLibrary.cyan_text = "하늘색";
            LanguangeLibrary.orange_text = "주황색";
            LanguangeLibrary.green_text = "녹색";
            LanguangeLibrary.black_text = "검정색";
            LanguangeLibrary.brown_text = "갈색";
            LanguangeLibrary.yellow_text = "노란색";
            LanguangeLibrary.magenta_text = "분홍색";
            LanguangeLibrary.purple_text = "보라색";
            LanguangeLibrary.description = "딱 맞는 색상을 선택하고 단어에 속지 마세요!";

            /* for other options */
            LanguangeLibrary.status_bahasa = 4;
        }
        else if (selected_languange == 5)   //chinese
        {
            /* Button and UI */
            LanguangeLibrary.play = "玩";
            LanguangeLibrary.high_score = "脑水平";
            LanguangeLibrary.live_high_score = "最好成绩 : ";
            LanguangeLibrary.score = "得分了 : ";
            LanguangeLibrary.exit = "出口";
            LanguangeLibrary.back = "支持";
            LanguangeLibrary.share = "分享";
            LanguangeLibrary.about = "模样";
            LanguangeLibrary.play_again = "再玩一次";
            LanguangeLibrary.menu = "菜单";
            LanguangeLibrary.game_over = "游戏结束";
            LanguangeLibrary.rate_us = "估价";
            LanguangeLibrary.like_us = "喜欢";
            LanguangeLibrary.how_to_play = "怎么玩";
            LanguangeLibrary.title_menu = "COLOR FOCUS";
            LanguangeLibrary.normal_mode = "正常";
            LanguangeLibrary.inverted_mode = "倒";
            LanguangeLibrary.select_mode = "选择模式";

            /*Gameplay color*/
            LanguangeLibrary.red_text = "红色";
            LanguangeLibrary.blue_text = "蓝色";
            LanguangeLibrary.cyan_text = "青色";
            LanguangeLibrary.orange_text = "橙色";
            LanguangeLibrary.green_text = "绿色";
            LanguangeLibrary.black_text = "黑色";
            LanguangeLibrary.brown_text = "褐色";
            LanguangeLibrary.yellow_text = "黄色";
            LanguangeLibrary.magenta_text = "粉红色";
            LanguangeLibrary.purple_text = "紫色";
            LanguangeLibrary.description = "只要选择合适的颜色，不要被文字所迷惑！";

            /* for other options */
            LanguangeLibrary.status_bahasa = 5;
        }
        else if (selected_languange == 6)    //thai
        {
            /* Button and UI */
            LanguangeLibrary.play = "เล่น";
            LanguangeLibrary.high_score = "ระดับสมอง";
            LanguangeLibrary.live_high_score = "คะแนนสูง : ";
            LanguangeLibrary.score = "คะแนน : ";
            LanguangeLibrary.exit = "ทางออก";
            LanguangeLibrary.back = "กลับ";
            LanguangeLibrary.share = "แบ่ง";
            LanguangeLibrary.about = "รอบ";
            LanguangeLibrary.play_again = "เล่นอีกครั้ง";
            LanguangeLibrary.menu = "เมนู";
            LanguangeLibrary.game_over = "จบเกม";
            LanguangeLibrary.rate_us = "ประเมิน";
            LanguangeLibrary.like_us = "ชอบ";
            LanguangeLibrary.how_to_play = "วิธีการเล่น";
            LanguangeLibrary.description = "เพียงแค่เลือกสีที่เหมาะสมและไม่หลงกลโดยคำ!";
            LanguangeLibrary.title_menu = "COLOR FOCUS";
            LanguangeLibrary.normal_mode = "ปกติ";
            LanguangeLibrary.inverted_mode = "กลับกัน";
            LanguangeLibrary.select_mode = "เลือกโหมด";

            /*Gameplay color*/
            LanguangeLibrary.red_text = "แดง";
            LanguangeLibrary.blue_text = "ฟ้า";
            LanguangeLibrary.cyan_text = "ฟ้า";
            LanguangeLibrary.orange_text = "ส้ม";
            LanguangeLibrary.green_text = "เขียว";
            LanguangeLibrary.black_text = "ดำ";
            LanguangeLibrary.brown_text = "น้ำตาล";
            LanguangeLibrary.yellow_text = "สีเหลือง";
            LanguangeLibrary.magenta_text = "สีชมพู";
            LanguangeLibrary.purple_text = "สีม่วง";
        }
    }
}
