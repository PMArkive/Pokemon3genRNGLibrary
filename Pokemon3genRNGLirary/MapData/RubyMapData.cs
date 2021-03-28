﻿using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Pokemon3genRNGLibrary.MapData
{
    public static class RubyMapData
    {
        public static class Field
        {
            public static GBAMap[] SelectMap(string mapNameKeyWord = "") 
                => tables.Where(_ => _.MapName.Contains(mapNameKeyWord)).ToArray();

            private static readonly GBAMap[] tables;
            static Field()
            {
                tables = new GBAMap[]
                {
                new RSGrass("101ばんどうろ", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ケムッソ", 2), ("ジグザグマ", 2), ("ケムッソ", 2), ("ケムッソ", 3),
                    ("ジグザグマ", 3), ("ジグザグマ", 3), ("ケムッソ", 3), ("ジグザグマ", 3),
                    ("ポチエナ", 2), ("ポチエナ", 2), ("ポチエナ", 3), ("ポチエナ", 3)
                })),
                new RSGrass("102ばんどうろ", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ジグザグマ", 3), ("ケムッソ", 3), ("ジグザグマ", 4), ("ケムッソ", 4),
                    ("タネボー", 3), ("タネボー", 4), ("ポチエナ", 3), ("ポチエナ", 3),
                    ("ポチエナ", 4), ("ラルトス", 4), ("ポチエナ", 4), ("アメタマ", 3)
                })),
                new RSGrass("103ばんどうろ", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ジグザグマ", 2), ("ジグザグマ", 3), ("ジグザグマ", 3), ("ジグザグマ", 4),
                    ("ポチエナ", 2), ("ポチエナ", 3), ("ポチエナ", 3), ("ポチエナ", 4),
                    ("キャモメ", 3), ("キャモメ", 3), ("キャモメ", 2), ("キャモメ", 4)
                })),
                new RSGrass("104ばんどうろ", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ジグザグマ", 4), ("ケムッソ", 4), ("ジグザグマ", 5), ("ケムッソ", 5),
                    ("ジグザグマ", 4), ("ジグザグマ", 5), ("スバメ", 4), ("スバメ", 5),
                    ("キャモメ", 4), ("キャモメ", 4), ("キャモメ", 3), ("キャモメ", 5)
                })),
                new RSGrass("110ばんどうろ", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ジグザグマ", 12), ("ラクライ", 12), ("ゴクリン", 12), ("ラクライ", 13),
                    ("マイナン", 13), ("ナゾノクサ", 13), ("マイナン", 13), ("ゴクリン", 13),
                    ("キャモメ", 12), ("キャモメ", 12), ("プラスル", 12), ("プラスル", 13)
                })),
                new RSGrass("111ばんどうろ", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("サンド", 20), ("ナックラー", 20), ("サンド", 21), ("ナックラー", 21),
                    ("サボネア", 19), ("サボネア", 21), ("サンド", 19), ("ナックラー", 19),
                    ("ヤジロン", 20), ("ヤジロン", 20), ("ヤジロン", 22), ("ヤジロン", 22)
                })),
                new RSGrass("112ばんどうろ", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ドンメル", 15), ("ドンメル", 15), ("ワンリキー", 15), ("ドンメル", 14),
                    ("ドンメル", 14), ("ワンリキー", 14), ("ドンメル", 16), ("ワンリキー", 16),
                    ("ドンメル", 16), ("ドンメル", 16), ("ドンメル", 16), ("ドンメル", 16)
                })),
                new RSGrass("113ばんどうろ", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("パッチール", 15), ("パッチール", 15), ("サンド", 15), ("パッチール", 14),
                    ("パッチール", 14), ("サンド", 14), ("パッチール", 16), ("サンド", 16),
                    ("パッチール", 16), ("エアームド", 16), ("パッチール", 16), ("エアームド", 16)
                })),
                new RSGrass("114ばんどうろ", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("チルット", 16), ("タネボー", 16), ("チルット", 17), ("チルット", 15),
                    ("タネボー", 15), ("ザングース", 16), ("コノハナ", 16), ("コノハナ", 18),
                    ("ザングース", 17), ("ザングース", 15), ("ザングース", 17), ("アメタマ", 15)
                })),
                new RSGrass("115ばんどうろ", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("チルット", 23), ("スバメ", 23), ("チルット", 25), ("スバメ", 24),
                    ("スバメ", 25), ("オオスバメ", 25), ("プリン", 24), ("プリン", 25),
                    ("キャモメ", 24), ("キャモメ", 24), ("キャモメ", 26), ("キャモメ", 25)
                })),
                new RSGrass("116ばんどうろ", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ジグザグマ", 6), ("ゴニョニョ", 6), ("ツチニン", 6), ("ゴニョニョ", 7),
                    ("ツチニン", 7), ("スバメ", 6), ("スバメ", 7), ("スバメ", 8),
                    ("ジグザグマ", 7), ("ジグザグマ", 8), ("エネコ", 7), ("エネコ", 8)
                })),
                new RSGrass("117ばんどうろ", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ジグザグマ", 13), ("ロゼリア", 13), ("ジグザグマ", 14), ("ロゼリア", 14),
                    ("マリル", 13), ("ナゾノクサ", 13), ("イルミーゼ", 13), ("イルミーゼ", 13),
                    ("イルミーゼ", 14), ("イルミーゼ", 14), ("バルビート", 13), ("アメタマ", 13)
                })),
                new RSGrass("118ばんどうろ", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ジグザグマ", 24), ("ラクライ", 24), ("ジグザグマ", 26), ("ラクライ", 26),
                    ("マッスグマ", 26), ("ライボルト", 26), ("キャモメ", 25), ("キャモメ", 25),
                    ("キャモメ", 26), ("キャモメ", 26), ("キャモメ", 27), ("カクレオン", 25)
                })),
                new RSGrass("119ばんどうろ", 15, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ジグザグマ", 25), ("マッスグマ", 25), ("ジグザグマ", 27), ("ナゾノクサ", 25),
                    ("マッスグマ", 27), ("ナゾノクサ", 26), ("ナゾノクサ", 27), ("ナゾノクサ", 24),
                    ("トロピウス", 25), ("トロピウス", 26), ("トロピウス", 27), ("カクレオン", 25)
                })),
                new RSGrass("120ばんどうろ", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ジグザグマ", 25), ("マッスグマ", 25), ("マッスグマ", 27), ("ナゾノクサ", 25),
                    ("マリル", 25), ("ナゾノクサ", 26), ("ナゾノクサ", 27), ("マリル", 27),
                    ("アブソル", 25), ("アブソル", 27), ("カクレオン", 25), ("アメタマ", 25)
                })),
                new RSGrass("121ばんどうろ", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ジグザグマ", 26), ("ヨマワル", 26), ("マッスグマ", 26), ("ヨマワル", 28),
                    ("マッスグマ", 28), ("ナゾノクサ", 26), ("ナゾノクサ", 28), ("クサイハナ", 28),
                    ("キャモメ", 26), ("キャモメ", 27), ("キャモメ", 28), ("カクレオン", 25)
                })),
                new RSGrass("123ばんどうろ", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ジグザグマ", 26), ("ヨマワル", 26), ("マッスグマ", 26), ("ヨマワル", 28),
                    ("マッスグマ", 28), ("ナゾノクサ", 26), ("ナゾノクサ", 28), ("クサイハナ", 28),
                    ("キャモメ", 26), ("キャモメ", 27), ("キャモメ", 28), ("カクレオン", 25)
                })),
                new RSGrass("130ばんすいどう", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ソーナノ", 30), ("ソーナノ", 35), ("ソーナノ", 25), ("ソーナノ", 40),
                    ("ソーナノ", 20), ("ソーナノ", 45), ("ソーナノ", 15), ("ソーナノ", 50),
                    ("ソーナノ", 10), ("ソーナノ", 5), ("ソーナノ", 10), ("ソーナノ", 5)
                })),
                new RSGrass("あさせのほらあな", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ズバット", 26), ("タマザラシ", 26), ("ズバット", 28), ("タマザラシ", 28),
                    ("ズバット", 30), ("タマザラシ", 30), ("ズバット", 32), ("タマザラシ", 32),
                    ("ゴルバット", 32), ("タマザラシ", 32), ("ゴルバット", 32), ("タマザラシ", 32)
                })),
                new RSGrass("あさせのほらあな 氷エリア", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ズバット", 26), ("タマザラシ", 26), ("ズバット", 28), ("タマザラシ", 28),
                    ("ズバット", 30), ("タマザラシ", 30), ("ユキワラシ", 26), ("タマザラシ", 32),
                    ("ゴルバット", 30), ("ユキワラシ", 28), ("ゴルバット", 32), ("ユキワラシ", 30)
                })),
                new RSGrass("いしのどうくつ 1F", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ズバット", 7), ("マクノシタ", 8), ("マクノシタ", 7), ("ズバット", 8),
                    ("マクノシタ", 9), ("ケーシィ", 8), ("マクノシタ", 10), ("マクノシタ", 6),
                    ("イシツブテ", 7), ("イシツブテ", 8), ("イシツブテ", 6), ("イシツブテ", 9)
                })),
                new RSGrass("いしのどうくつ B1F", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ズバット", 9), ("ココドラ", 10), ("ココドラ", 9), ("ココドラ", 11),
                    ("ズバット", 10), ("ケーシィ", 9), ("マクノシタ", 10), ("マクノシタ", 11),
                    ("クチート", 10), ("クチート", 10), ("クチート", 9), ("クチート", 11)
                })),
                new RSGrass("いしのどうくつ B2F", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ズバット", 10), ("ココドラ", 11), ("ココドラ", 10), ("ズバット", 11),
                    ("ココドラ", 12), ("ケーシィ", 10), ("クチート", 10), ("クチート", 11),
                    ("クチート", 12), ("クチート", 10), ("クチート", 12), ("クチート", 10)
                })),
                new RSGrass("いしのどうくつ 小部屋", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ズバット", 7), ("マクノシタ", 8), ("マクノシタ", 7), ("ズバット", 8),
                    ("マクノシタ", 9), ("ケーシィ", 8), ("マクノシタ", 10), ("マクノシタ", 6),
                    ("ココドラ", 7), ("ココドラ", 8), ("ココドラ", 7), ("ココドラ", 8)
                })),
                new RSGrass("おくりびやま 1F-3F", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ヨマワル", 27), ("ヨマワル", 28), ("ヨマワル", 26), ("ヨマワル", 25),
                    ("ヨマワル", 29), ("ヨマワル", 24), ("ヨマワル", 23), ("ヨマワル", 22),
                    ("ヨマワル", 29), ("ヨマワル", 24), ("ヨマワル", 29), ("ヨマワル", 24)
                })),
                new RSGrass("おくりびやま 4F-6F", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ヨマワル", 27), ("ヨマワル", 28), ("ヨマワル", 26), ("ヨマワル", 25),
                    ("ヨマワル", 29), ("ヨマワル", 24), ("ヨマワル", 23), ("ヨマワル", 22),
                    ("カゲボウズ", 27), ("カゲボウズ", 27), ("カゲボウズ", 25), ("カゲボウズ", 29)
                })),
                new RSGrass("おくりびやま 外", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ヨマワル", 27), ("アサナン", 27), ("ヨマワル", 28), ("アサナン", 29),
                    ("ヨマワル", 29), ("ロコン", 27), ("ロコン", 29), ("ロコン", 25),
                    ("キャモメ", 27), ("キャモメ", 27), ("キャモメ", 26), ("キャモメ", 28)
                })),
                new RSGrass("おくりびやま 頂上", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ヨマワル", 28), ("ヨマワル", 29), ("ヨマワル", 27), ("ヨマワル", 26),
                    ("ヨマワル", 30), ("ヨマワル", 25), ("ヨマワル", 24), ("カゲボウズ", 28),
                    ("カゲボウズ", 26), ("カゲボウズ", 30), ("チリーン", 28), ("チリーン", 28)
                })),
                new RSGrass("かいていどうくつ", 4, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ズバット", 30), ("ズバット", 31), ("ズバット", 32), ("ズバット", 33),
                    ("ズバット", 28), ("ズバット", 29), ("ズバット", 34), ("ズバット", 35),
                    ("ゴルバット", 34), ("ゴルバット", 35), ("ゴルバット", 33), ("ゴルバット", 36)
                })),
                new RSGrass("カナシダトンネル", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ゴニョニョ", 6), ("ゴニョニョ", 7), ("ゴニョニョ", 6), ("ゴニョニョ", 6),
                    ("ゴニョニョ", 7), ("ゴニョニョ", 7), ("ゴニョニョ", 5), ("ゴニョニョ", 8),
                    ("ゴニョニョ", 5), ("ゴニョニョ", 8), ("ゴニョニョ", 5), ("ゴニョニョ", 8)
                })),
                new RSSafariGrass("サファリゾーン 入口エリア", 25, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ナゾノクサ", 25), ("ナゾノクサ", 27), ("キリンリキ", 25), ("キリンリキ", 27),
                    ("ネイティ", 25), ("ドードー", 25), ("クサイハナ", 25), ("ソーナンス", 27),
                    ("ピカチュウ", 25), ("ソーナンス", 27), ("ピカチュウ", 27), ("ソーナンス", 29)
                })),
                new RSSafariGrass("サファリゾーン 西エリア", 25, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ナゾノクサ", 25), ("ナゾノクサ", 27), ("キリンリキ", 25), ("キリンリキ", 27),
                    ("ネイティ", 25), ("ドードー", 25), ("クサイハナ", 25), ("ソーナンス", 27),
                    ("ピカチュウ", 25), ("ソーナンス", 27), ("ピカチュウ", 27), ("ソーナンス", 29)
                })),
                new RSSafariGrass("サファリゾーン マッハエリア", 25, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("サイホーン", 27), ("ナゾノクサ", 27), ("サイホーン", 29), ("ナゾノクサ", 29),
                    ("ドードー", 27), ("クサイハナ", 29), ("クサイハナ", 31), ("ドードー", 29),
                    ("ドードリオ", 29), ("カイロス", 27), ("ドードリオ", 31), ("カイロス", 29)
                })),
                new RSSafariGrass("サファリゾーン ダートエリア", 25, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ゴマゾウ", 27), ("ナゾノクサ", 27), ("ゴマゾウ", 29), ("ナゾノクサ", 29),
                    ("ネイティ", 27), ("クサイハナ", 29), ("クサイハナ", 31), ("ネイティ", 29),
                    ("ネイティオ", 29), ("ヘラクロス", 27), ("ネイティオ", 31), ("ヘラクロス", 29)
                })),
                new RSGrass("そらのはしら 1F", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("クチート", 48), ("ゴルバット", 48), ("ゴルバット", 50), ("クチート", 50),
                    ("ネンドール", 48), ("サマヨール", 48), ("サマヨール", 50), ("ネンドール", 49),
                    ("ネンドール", 47), ("ネンドール", 50), ("ネンドール", 47), ("ネンドール", 50)
                })),
                new RSGrass("そらのはしら 3F", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("クチート", 51), ("ゴルバット", 51), ("ゴルバット", 53), ("クチート", 53),
                    ("ネンドール", 51), ("サマヨール", 51), ("サマヨール", 53), ("ネンドール", 52),
                    ("ネンドール", 50), ("ネンドール", 53), ("ネンドール", 50), ("ネンドール", 53)
                })),
                new RSGrass("そらのはしら 5F", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("クチート", 54), ("ゴルバット", 54), ("ゴルバット", 56), ("クチート", 56),
                    ("ネンドール", 54), ("サマヨール", 54), ("サマヨール", 56), ("ネンドール", 55),
                    ("ネンドール", 56), ("チルタリス", 57), ("チルタリス", 54), ("チルタリス", 60)
                })),
                new RSGrass("チャンピオンロード 1F", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ゴルバット", 40), ("ハリテヤマ", 40), ("コドラ", 40), ("ドゴーム", 40),
                    ("ズバット", 36), ("マクノシタ", 36), ("ゴルバット", 38), ("ハリテヤマ", 38),
                    ("ココドラ", 36), ("ゴニョニョ", 36), ("ココドラ", 36), ("ゴニョニョ", 36)
                })),
                new RSGrass("チャンピオンロード B1F", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ゴルバット", 40), ("ハリテヤマ", 40), ("コドラ", 40), ("チャーレム", 40),
                    ("ゴルバット", 38), ("ハリテヤマ", 38), ("ゴルバット", 42), ("ハリテヤマ", 42),
                    ("コドラ", 42), ("アサナン", 38), ("コドラ", 42), ("アサナン", 38)
                })),
                new RSGrass("チャンピオンロード B2F", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ゴルバット", 40), ("クチート", 40), ("コドラ", 40), ("チャーレム", 40),
                    ("ゴルバット", 42), ("クチート", 42), ("ゴルバット", 44), ("クチート", 44),
                    ("コドラ", 42), ("チャーレム", 42), ("コドラ", 44), ("チャーレム", 44)
                })),
                new RSGrass("デコボコさんどう", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ドンメル", 19), ("ドンメル", 19), ("ワンリキー", 19), ("ドンメル", 18),
                    ("バネブー", 18), ("ワンリキー", 18), ("バネブー", 19), ("ワンリキー", 20),
                    ("ドンメル", 20), ("バネブー", 20), ("ドンメル", 20), ("バネブー", 20)
                })),
                new RSGrass("トウカのもり", 20, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ジグザグマ", 5), ("ケムッソ", 5), ("キノココ", 5), ("ジグザグマ", 6),
                    ("カラサリス", 5), ("マユルド", 5), ("ケムッソ", 6), ("キノココ", 6),
                    ("スバメ", 5), ("ナマケロ", 5), ("スバメ", 6), ("ナマケロ", 6)
                })),
                new RSGrass("ニューキンセツ 入口", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ビリリダマ", 24), ("コイル", 24), ("ビリリダマ", 25), ("コイル", 25),
                    ("ビリリダマ", 23), ("コイル", 23), ("ビリリダマ", 26), ("コイル", 26),
                    ("ビリリダマ", 22), ("コイル", 22), ("ビリリダマ", 22), ("コイル", 22)
                })),
                new RSGrass("ニューキンセツ 地下", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ビリリダマ", 24), ("コイル", 24), ("ビリリダマ", 25), ("コイル", 25),
                    ("ビリリダマ", 23), ("コイル", 23), ("ビリリダマ", 26), ("コイル", 26),
                    ("ビリリダマ", 22), ("コイル", 22), ("マルマイン", 26), ("レアコイル", 26)
                })),
                new RSGrass("ほのおのぬけみち", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ドンメル", 15), ("ドガース", 15), ("ドンメル", 16), ("ワンリキー", 15),
                    ("コータス", 15), ("マグマッグ", 15), ("ドガース", 16), ("ワンリキー", 16),
                    ("コータス", 14), ("コータス", 16), ("ベトベター", 14), ("ベトベター", 14)
                })),
                new RSGrass("めざめのほこら 入口", 4, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ズバット", 30), ("ズバット", 31), ("ズバット", 32), ("ズバット", 33),
                    ("ズバット", 28), ("ズバット", 29), ("ズバット", 34), ("ズバット", 35),
                    ("ゴルバット", 34), ("ゴルバット", 35), ("ゴルバット", 33), ("ゴルバット", 36)
                })),
                new RSGrass("めざめのほこら", 4, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ズバット", 30), ("ズバット", 31), ("ズバット", 32), ("クチート", 30),
                    ("クチート", 32), ("クチート", 34), ("ズバット", 33), ("ズバット", 34),
                    ("ゴルバット", 34), ("ゴルバット", 35), ("ゴルバット", 33), ("ゴルバット", 36)
                })),
                new RSGrass("りゅうせいのたき 入口", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ズバット", 16), ("ズバット", 17), ("ズバット", 18), ("ズバット", 15),
                    ("ズバット", 14), ("ソルロック", 16), ("ソルロック", 18), ("ソルロック", 14),
                    ("ズバット", 19), ("ズバット", 20), ("ズバット", 19), ("ズバット", 20)
                })),
                new RSGrass("りゅうせいのたき 奥", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ゴルバット", 33), ("ゴルバット", 35), ("ゴルバット", 33), ("ソルロック", 35),
                    ("ソルロック", 33), ("ソルロック", 37), ("ゴルバット", 35), ("ソルロック", 39),
                    ("ゴルバット", 38), ("ゴルバット", 40), ("ゴルバット", 38), ("ゴルバット", 40)
                })),
                new RSGrass("りゅうせいのたき 最奥", 10, GBASlot.CreateTable(new (string, uint)[]
                {
                    ("ゴルバット", 33), ("ゴルバット", 35), ("タツベイ", 30), ("ソルロック", 35),
                    ("タツベイ", 35), ("ソルロック", 37), ("タツベイ", 25), ("ソルロック", 39),
                    ("ゴルバット", 38), ("ゴルバット", 40), ("ゴルバット", 38), ("ゴルバット", 40)
                }))
                };
            }
        }

        public static class Surf
        {
            public static GBAMap[] SelectMap(string mapNameKeyWord = "")
                => tables.Where(_ => _.MapName.Contains(mapNameKeyWord)).ToArray();

            private static readonly GBAMap[] tables;
            static Surf()
            {
                tables = new GBAMap[]
                {
                new RSSurf("102ばんどうろ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("マリル", 20, 11), ("マリル", 10, 11), ("マリル", 30, 6),
                    ("マリル", 5, 6), ("アメタマ", 20, 11),
                })),
                new RSSurf("103ばんどうろ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31), ("キャモメ", 10, 21), ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6), ("ペリッパー", 25, 6),
                })),
                new RSSurf("104ばんどうろ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("105ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("106ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("107ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("108ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("109ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("110ばんどうろ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("111ばんどうろ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("マリル", 20, 11),
                    ("マリル", 10, 11),
                    ("マリル", 30, 6),
                    ("マリル", 5, 6),
                    ("アメタマ", 20, 11),
                })),
                new RSSurf("114ばんどうろ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("マリル", 20, 11),
                    ("マリル", 10, 11),
                    ("マリル", 30, 6),
                    ("マリル", 5, 6),
                    ("アメタマ", 20, 11),
                })),
                new RSSurf("115ばんどうろ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("117ばんどうろ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("マリル", 20, 11),
                    ("マリル", 10, 11),
                    ("マリル", 30, 6),
                    ("マリル", 5, 6),
                    ("アメタマ", 20, 11),
                })),
                new RSSurf("118ばんどうろ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("119ばんどうろ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("120ばんどうろ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("マリル", 20, 11),
                    ("マリル", 10, 11),
                    ("マリル", 30, 6),
                    ("マリル", 5, 6),
                    ("アメタマ", 20, 11),
                })),
                new RSSurf("121ばんどうろ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("122ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("123ばんどうろ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("124ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("125ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("126ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("127ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("128ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("129ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ホエルオー", 35, 6),
                })),
                new RSSurf("130ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("131ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("132ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("133ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("134ばんすいどう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("トウカシティ", 1, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("マリル", 20, 11),
                    ("マリル", 10, 11),
                    ("マリル", 30, 6),
                    ("マリル", 5, 6),
                    ("マリル", 5, 6),
                })),
                new RSSurf("ムロタウン", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("カイナシティ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("ミナモシティ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("トクサネシティ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("ルネシティ", 1, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 5, 31),
                    ("コイキング", 10, 21),
                    ("コイキング", 15, 11),
                    ("コイキング", 25, 6),
                    ("コイキング", 25, 6),
                })),
                new RSSurf("キナギタウン", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("サイユウシティ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("キャモメ", 10, 21),
                    ("キャモメ", 15, 11),
                    ("ペリッパー", 25, 6),
                    ("ペリッパー", 25, 6),
                })),
                new RSSurf("すてられぶね", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("メノクラゲ", 5, 31),
                    ("メノクラゲ", 5, 31),
                    ("メノクラゲ", 5, 31),
                    ("ドククラゲ", 30, 6),
                })),
                new RSSurf("りゅうせいのたき 入口", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ズバット", 5, 31),
                    ("ズバット", 30, 6),
                    ("ソルロック", 25, 11),
                    ("ソルロック", 15, 11),
                    ("ソルロック", 5, 11),
                })),
                new RSSurf("りゅうせいのたき 奥", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ゴルバット", 30, 6),
                    ("ゴルバット", 30, 6),
                    ("ソルロック", 25, 11),
                    ("ソルロック", 15, 11),
                    ("ソルロック", 5, 11),
                })),
                new RSSurf("あさせのほらあな", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("ズバット", 5, 31),
                    ("タマザラシ", 25, 6),
                    ("タマザラシ", 25, 6),
                    ("タマザラシ", 25, 11),
                })),
                new RSSurf("かいていどうくつ", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 5, 31),
                    ("ズバット", 5, 31),
                    ("ズバット", 30, 6),
                    ("ゴルバット", 30, 6),
                    ("ゴルバット", 30, 6),
                })),
                new RSSurf("チャンピオンロード", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ゴルバット", 30, 6),
                    ("ゴルバット", 25, 6),
                    ("ゴルバット", 35, 6),
                    ("ゴルバット", 35, 6),
                    ("ゴルバット", 35, 6),
                })),
                new RSSafariSurf("サファリゾーン 西エリア", 9, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コダック", 20, 11),
                    ("コダック", 20, 11),
                    ("コダック", 30, 6),
                    ("コダック", 30, 6),
                    ("コダック", 30, 6),
                })),
                new RSSafariSurf("サファリゾーン マッハエリア", 9, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コダック", 20, 11),
                    ("コダック", 20, 11),
                    ("コダック", 30, 6),
                    ("ゴルダック", 30, 6),
                    ("ゴルダック", 25, 16),
                })),
                new RSSurf("すいちゅう", 4, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("パールル", 20, 11),
                    ("チョンチー", 20, 11),
                    ("パールル", 30, 6),
                    ("ジーランス", 30, 6),
                    ("ジーランス", 30, 6),
                }))
                };
            }
        }

        public static class OldRod
        {
            public static GBAMap[] SelectMap(string mapNameKeyWord = "")
                => tables.Where(_ => _.MapName.Contains(mapNameKeyWord)).ToArray();

            private static readonly GBAMap[] tables;
            static OldRod()
            {
                tables = new GBAMap[]
                {
                new RSOldRod("102ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("トサキント", 5, 6) })),
                new RSOldRod("103ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("104ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("コイキング", 5, 6) })),
                new RSOldRod("105ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("106ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("107ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("108ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("109ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("110ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("111ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("トサキント", 5, 6) })),
                new RSOldRod("114ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("トサキント", 5, 6) })),
                new RSOldRod("115ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("117ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("トサキント", 5, 6) })),
                new RSOldRod("118ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSRoute119OldRod("119ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSFeebasSpotOldRod("119ばんどうろ(ヒンバススポット)", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("120ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("トサキント", 5, 6) })),
                new RSOldRod("121ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("122ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("123ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("124ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("125ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("126ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("127ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("128ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("129ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("130ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("131ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("132ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("133ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("134ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("トウカシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("トサキント", 5, 6) })),
                new RSOldRod("ムロタウン", 10, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("カイナシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("ミナモシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("トクサネシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("ルネシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("コイキング", 10, 6) })),
                new RSOldRod("キナギタウン", 10, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("サイユウシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("すてられぶね", 20, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("りゅうせいのたき", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("トサキント", 5, 6) })),
                new RSOldRod("あさせのほらあな", 10, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("かいていどうくつ", 10, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("メノクラゲ", 5, 6) })),
                new RSOldRod("チャンピオンロード", 30, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("トサキント", 5, 6) })),
                new RSSafariOldRod("サファリゾーン", 35, GBASlot.CreateTable(new (string, uint, uint)[] { ("コイキング", 5, 6), ("トサキント", 5, 6) })),

                };
            }
        }

        public static class GoodRod
        {
            public static GBAMap[] SelectMap(string mapNameKeyWord = "")
                => tables.Where(_ => _.MapName.Contains(mapNameKeyWord)).ToArray();

            private static readonly GBAMap[] tables;
            static GoodRod()
            {
                tables = new GBAMap[]
                {
                new RSGoodRod("102ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("トサキント", 10, 21),
                    ("ヘイガニ", 10, 21),
                })),
                new RSGoodRod("103ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("104ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("コイキング", 10, 21),
                    ("コイキング", 10, 21),
                })),
                new RSGoodRod("105ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("106ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("107ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("108ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("109ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("110ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("111ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("トサキント", 10, 21),
                    ("ドジョッチ", 10, 21),
                })),
                new RSGoodRod("114ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("トサキント", 10, 21),
                    ("ドジョッチ", 10, 21),
                })),
                new RSGoodRod("115ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("117ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("トサキント", 10, 21),
                    ("ヘイガニ", 10, 21),
                })),
                new RSGoodRod("118ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("キバニア", 10, 21),
                })),
                new RSRoute119GoodRod("119ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("キバニア", 10, 21),
                })),
                new RSFeebasSpotGoodRod("119ばんどうろ(ヒンバススポット)", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("キバニア", 10, 21),
                })),
                new RSGoodRod("120ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("トサキント", 10, 21),
                    ("ドジョッチ", 10, 21),
                })),
                new RSGoodRod("121ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("122ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("123ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("124ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("125ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("126ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("127ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("128ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("ラブカス", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("129ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("130ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("131ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("132ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("133ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("134ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("トウカシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("トサキント", 10, 21),
                    ("ヘイガニ", 10, 21),
                })),
                new RSGoodRod("ムロタウン", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("カイナシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("ミナモシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("トクサネシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("ルネシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("コイキング", 10, 21),
                    ("コイキング", 10, 21),
                })),
                new RSGoodRod("キナギタウン", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("サイユウシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("ラブカス", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("すてられぶね", 20, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("メノクラゲ", 10, 21),
                })),
                new RSGoodRod("りゅうせいのたき", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("トサキント", 10, 21),
                    ("ドジョッチ", 10, 21),
                })),
                new RSGoodRod("あさせのほらあな", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("かいていどうくつ", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("メノクラゲ", 10, 21),
                    ("ホエルコ", 10, 21),
                })),
                new RSGoodRod("チャンピオンロード", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("トサキント", 10, 21),
                    ("ドジョッチ", 10, 21),
                })),
                new RSSafariGoodRod("サファリゾーン", 35, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 10, 21),
                    ("トサキント", 10, 16),
                    ("トサキント", 10, 21),
                })),

                };
            }
        }

        public static class SuperRod
        {
            public static GBAMap[] SelectMap(string mapNameKeyWord = "")
                => tables.Where(_ => _.MapName.Contains(mapNameKeyWord)).ToArray();

            private static readonly GBAMap[] tables;
            static SuperRod()
            {
                tables = new GBAMap[]
                {
                new RSSuperRod("102ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ヘイガニ", 25, 6),
                    ("ヘイガニ", 30, 6),
                    ("ヘイガニ", 20, 6),
                    ("ヘイガニ", 35, 6),
                    ("ヘイガニ", 40, 6),
                })),
                new RSSuperRod("103ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("サメハダー", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("104ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 25, 6),
                    ("コイキング", 30, 6),
                    ("コイキング", 20, 6),
                    ("コイキング", 35, 6),
                    ("コイキング", 40, 6),
                })),
                new RSSuperRod("105ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 20, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("106ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 20, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("107ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 20, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("108ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 20, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("109ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 20, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("110ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 20, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("111ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ドジョッチ", 25, 6),
                    ("ドジョッチ", 30, 6),
                    ("ドジョッチ", 20, 6),
                    ("ドジョッチ", 35, 6),
                    ("ドジョッチ", 40, 6),
                })),
                new RSSuperRod("114ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ドジョッチ", 25, 6),
                    ("ドジョッチ", 30, 6),
                    ("ドジョッチ", 20, 6),
                    ("ドジョッチ", 35, 6),
                    ("ドジョッチ", 40, 6),
                })),
                new RSSuperRod("115ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 20, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("117ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ヘイガニ", 25, 6),
                    ("ヘイガニ", 30, 6),
                    ("ヘイガニ", 20, 6),
                    ("ヘイガニ", 35, 6),
                    ("ヘイガニ", 40, 6),
                })),
                new RSSuperRod("118ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("サメハダー", 30, 6),
                    ("キバニア", 30, 6),
                    ("キバニア", 20, 6),
                    ("キバニア", 35, 6),
                    ("キバニア", 40, 6),
                })),
                new RSRoute119SuperRod("119ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("キバニア", 25, 6),
                    ("キバニア", 30, 6),
                    ("キバニア", 20, 6),
                    ("キバニア", 35, 6),
                    ("キバニア", 40, 6),
                })),
                new RSFeebasSpotSuperRod("119ばんどうろ(ヒンバススポット)", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("キバニア", 25, 6),
                    ("キバニア", 30, 6),
                    ("キバニア", 20, 6),
                    ("キバニア", 35, 6),
                    ("キバニア", 40, 6),
                })),
                new RSSuperRod("120ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ドジョッチ", 25, 6),
                    ("ドジョッチ", 30, 6),
                    ("ドジョッチ", 20, 6),
                    ("ドジョッチ", 35, 6),
                    ("ドジョッチ", 40, 6),
                })),
                new RSSuperRod("121ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 20, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("122ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("サメハダー", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("123ばんどうろ", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 20, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("124ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("サメハダー", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("125ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("サメハダー", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("126ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("サメハダー", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("127ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("サメハダー", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("128ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ラブカス", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("サニーゴ", 30, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("129ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("サメハダー", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("130ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("サメハダー", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("131ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("サメハダー", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("132ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("サメハダー", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("タッツー", 25, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("133ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("サメハダー", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("タッツー", 25, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("134ばんすいどう", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("サメハダー", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("タッツー", 25, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("トウカシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ヘイガニ", 25, 6),
                    ("ヘイガニ", 30, 6),
                    ("ヘイガニ", 20, 6),
                    ("ヘイガニ", 35, 6),
                    ("ヘイガニ", 40, 6),
                })),
                new RSSuperRod("ムロタウン", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 20, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("カイナシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 20, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("ミナモシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 30, 6),
                    ("ヒトデマン", 25, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("トクサネシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("サメハダー", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("ルネシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("コイキング", 30, 6),
                    ("コイキング", 30, 6),
                    ("ギャラドス", 35, 6),
                    ("ギャラドス", 35, 11),
                    ("ギャラドス", 5, 41),
                })),
                new RSSuperRod("キナギタウン", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("サメハダー", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("サイユウシティ", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ラブカス", 30, 6),
                    ("ホエルコ", 30, 6),
                    ("サニーゴ", 30, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("すてられぶね", 20, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("メノクラゲ", 25, 6),
                    ("メノクラゲ", 30, 6),
                    ("ドククラゲ", 30, 6),
                    ("ドククラゲ", 25, 6),
                    ("ドククラゲ", 20, 6),
                })),
                new RSSuperRod("りゅうせいのたき 入口", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ドジョッチ", 25, 6),
                    ("ドジョッチ", 30, 6),
                    ("ドジョッチ", 20, 6),
                    ("ドジョッチ", 35, 6),
                    ("ドジョッチ", 40, 6),
                })),
                new RSSuperRod("りゅうせいのたき 奥", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ドジョッチ", 25, 6),
                    ("ドジョッチ", 30, 6),
                    ("ナマズン", 30, 6),
                    ("ナマズン", 35, 6),
                    ("ナマズン", 40, 6),
                })),
                new RSSuperRod("あさせのほらあな", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 20, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("かいていどうくつ", 10, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ホエルコ", 25, 6),
                    ("ホエルコ", 30, 6),
                    ("ホエルコ", 20, 6),
                    ("ホエルコ", 35, 6),
                    ("ホエルコ", 40, 6),
                })),
                new RSSuperRod("チャンピオンロード", 30, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ドジョッチ", 25, 6),
                    ("ドジョッチ", 30, 6),
                    ("ナマズン", 30, 6),
                    ("ナマズン", 35, 6),
                    ("ナマズン", 40, 6),
                })),
                new RSSafariSuperRod("サファリゾーン", 35, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("トサキント", 25, 6),
                    ("トサキント", 30, 6),
                    ("アズマオウ", 30, 6),
                    ("アズマオウ", 35, 6),
                    ("アズマオウ", 25, 6),
                })),
                };
            }
        }

        public static class RockSmash
        {
            public static GBAMap[] SelectMap(string mapNameKeyWord = "")
                => tables.Where(_ => _.MapName.Contains(mapNameKeyWord)).ToArray();

            private static readonly GBAMap[] tables;
            static RockSmash()
            {
                tables = new GBAMap[]
                {
                new RSRockSmash("111ばんどうろ", 20, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("イシツブテ", 10, 6),
                    ("イシツブテ", 5, 6),
                    ("イシツブテ", 15, 6),
                    ("イシツブテ", 15, 6),
                    ("イシツブテ", 15, 6),
                })),
                new RSRockSmash("114ばんどうろ", 20, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("イシツブテ", 10, 6),
                    ("イシツブテ", 5, 6),
                    ("イシツブテ", 15, 6),
                    ("イシツブテ", 15, 6),
                    ("イシツブテ", 15, 6),
                })),
                new RSRockSmash("いしのどうくつ", 20, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("イシツブテ", 10, 6),
                    ("ノズパス", 10, 11),
                    ("イシツブテ", 5, 6),
                    ("イシツブテ", 15, 6),
                    ("イシツブテ", 15, 6),
                })),
                new RSRockSmash("チャンピオンロード", 20, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("ゴローン", 30, 11),
                    ("イシツブテ", 30, 11),
                    ("ゴローン", 35, 6),
                    ("ゴローン", 35, 6),
                    ("ゴローン", 35, 6),
                })),
                new RSSafariRockSmash("サファリゾーン ダートエリア", 25, GBASlot.CreateTable(new (string, uint, uint)[]
                {
                    ("イシツブテ", 10, 6),
                    ("イシツブテ", 5, 6),
                    ("イシツブテ", 15, 6),
                    ("イシツブテ", 20, 6),
                    ("イシツブテ", 25, 6),
                })),
                };
            }
        }

    }

}