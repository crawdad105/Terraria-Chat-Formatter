
using System.Windows.Forms;
using System.Xml;

namespace TerrariaText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color GetCharColor(int Index)
        {
            richTextBox1.Select(Index, 1);
            Color c = richTextBox1.SelectionColor;
            richTextBox1.SelectionLength = 0;
            return c;
        }
        char GetChar(int Index)
        {
            return richTextBox1.Text.ElementAt(Index);
        }

        string ValidChars = "┯┰┱┲❗►◄Ăă0123456789Ǖǖ¤Ð¢℥Ω℧Kℶℷℸⅇ⅊⚌⚍⚎⚏⚭⚮⌀⏑⏒⏓⏔⏕⏖⏗⏘⏙⏠⏡⏦ᶙᶚᶸᵯᵰᵴᵶᵹᵼᵽᵾᵿ⁁⁊⸜⸝¶¥£⅕⅙⅛⅔⅖⅗⅘⅜⅚⅐⅝↉⅓⅑⅒⅞←↑→↓↔↕↖↗↘↙↚↛↜↝↞↟↠↡↢↣↤↥↦↧↨↩↪↫↬↭↮↯↰↱↲↳↴↵↶↷↸↹↺↻↼↽↾↿⇀⇁⇂⇃⇄⇅⇆⇇⇈⇉⇊⇋⇌⇍⇎⇏⇐⇑⇒⇓⇔⇕⇖⇗⇘⇙⇚⇛⇜⇝⇞⇟⇠⇡⇢⇣⇤⇥⇦⇨⇩⇪⇧⇫⇬⇭⇮⇯⇰⇱⇲⇳⇴⇵⇶⇷⇸⇹⇺⇻⇼⇽⇾⇿⟰⟱⟲⟳⟴⟵⟶⟷⟸⟹⟺⟻⟼⟽⟾⟿⤀⤁⤂⤃⤄⤅⤆⤇⤈⤉⤊⤋⤌⤍⤎⤏⤐⤑⤒⤓⤔⤕⤖⤗⤘⤙⤚⤛⤜⤝⤞⤟⤠⤡⤢⤣⤤⤥⤦⤧⤨⤩⤪⤫⤬⤭⤮⤯⤰⤱⤲⤳⤴⤵⤶⤷⤸⤹⤺⤻⤼⤽⤾⤿⥀⥁⥂⥃⥄⥅⥆⥇⥈⥉⥊⥋⥌⥍⥎⥏⥐⥑⥒⥓⥔⥕⥖⥗⥘⥙⥚⥛⥜⥝⥞⥟⥠⥡⥢⥣⥤⥥⥦⥧⥨⥩⥪⥫⥬⥭⥮⥯⥰⥱⥲⥳⥴⥵⥶⥷⥸⥹⥺⥻⥼⥽⥾⥿➔➘➙➚➛➜➝➞➝➞➟➠➡➢➣➤➥➦➧➨➩➩➪➫➬➭➮➯➱➲➳➴➵➶➷➸➹➺➻➼➽➾⬀⬁⬂⬃⬄⬅⬆⬇⬈⬉⬊⬋⬌⬍⬎⬏⬐⬑☇☈⏎⍃⍄⍅⍆⍇⍈⍐⍗⍌⍓⍍⍔⍏⍖♾⎌☊☋☌☍⌃⌄⌤⌅⌆⌇⚋⚊⌌⌍⌎⌏⌐⌑⌔⌕⌗⌙⌢⌣⌯⌬⌭⌮⌖⌰⌱⌲⌳⌴⌵⌶⌷⌸⌹⌺⌻⌼⍯⍰⌽⌾⌿⍀⍁⍂⍉⍊⍋⍎⍏⍑⍒⍕⍖⍘⍙⍚⍛⍜⍝⍞⍠⍟⍡⍢⍣⍤⍥⍨⍩⍦⍧⍬⍿⍪⍮⍫⍱⍲⍭⍳⍴⍵⍶⍷⍸⍹⍺⍼⍽⍾⎀⎁⎂⎃⎄⎅⎆⎉⎊⎋⎍⎎⎏⎐⎑⎒⎓⎔⎕⏣⌓⏥⏢⎖⎲⎳⎴⎵⎶⎸⎹⎺⎻⎼⎽⎾⎿⏀⏁⏂⏃⏄⏅⏆⏇⏈⏉⏉⏋⏌⏍⏐⏤⏚⏛Ⓝℰⓦ!⌘«»‹›‘’“”„‚❝❞£¥€$¢¬¶@§®©™°×±√‰∞≈÷~≠¹²³½¼¾‐–—|⁄[]{}†‡…·•●⌥⌃⇧↩¡¿‽⁂∴∵◊※←→↑↓☜☞☝☟✔★☆♺☼☂☺☹☃✉✿✄✈✌✎♠♦♣♥♪♫♯♀♂ßÁáÀàÅåÄäÆæÇçÉéÈèÊêÍíÌìÎîÑñÓóÒòÔôÖöØøÚúÙùÜüŽž₳€₡¢₢₵₫£₤₣ƒ₲₭₥₦₱＄$₮₩¥₴₰¤₪₯₠₧₨~ƻƼƽ¹¸¬¨ɂǁ¯Ɂǂ¡´°¦}{|.,·])[/_¿º§*-+(!&%$¼¾½¶©®@Ɀ`Ȿ^'=:;<>?÷ℾℿ℔℩℉⅀℈þðÞµªⱽⱺⱹⱷⱶⱵⱴⱱⱰⱦȶȴȣȢȡȝȜțȋȊȉȈǯǮǃǀƿƾƺƹƸƷƲưƪƣƢƟƛƖƕƍſ⸀⸁⸂⸃⸄⸅⸆⸇⸈⸉⸊⸋⸌⸍⸎⸏⸐⸑⸒⸔⸕▲▼◀▶◢◣◥◤△▽◿◺◹◸▴▾◂▸▵▿◃▹◁▷◅▻◬⟁⧋⧊⊿∆∇◭◮⧩⧨⌔⟐◇◆◈⬖⬗⬘⬙⬠⬡⎔⋄◊⧫⬢⬣▰▪◼▮◾▗▖■∎▃▄▅▆▇█▌▐▍▎▉▊▋❘❙❚▀▘▝▙▚▛▜▟▞░▒▓▂▁▬▔▫▯▭▱◽□◻▢⊞⊡⊟⊠▣▤▥▦⬚▧▨▩⬓◧⬒◨◩◪⬔⬕❏❐❑❒⧈◰◱◳◲◫⧇⧅⧄⍁⍂⟡⧉⚬○⚪◌◍◎◯❍◉⦾⊙⦿⊜⊖⊘⊚⊛⊝●⚫⦁◐◑◒◓◔◕⦶⦸◵◴◶◷⊕⊗⦇⦈⦉⦊❨❩⸨⸩◖◗❪❫❮❯❬❭❰❱⊏⊐⊑⊒◘◙◚◛◜◝◞◟◠◡⋒⋓⋐⋑╰╮╭╯⌒╳✕╱╲⧸⧹⌓◦❖✖✚✜⧓⧗⧑⧒⧖_⚊╴╼╾⁃-–⎯—―╶╺╸─━┄┅┈┉╌╍═≣≡☰☱☲☳☴☵☶☷╵╷╹╻│▕▏┃┆┇┊╎┋╿╽┌┍┎┏┐┑┒┓└┕┖┗┘┙┚┛├┝┞┟┠┡┢┣┤┥┦┧┨┩┪┫┬┭┮┳┴┵┶┷┸┹┺┻┼┽┾┿╀╁╂╃╄╅╆╇╈╉╊╋╏║╔╒╓╕╖╗╚╘╙╛╜╝╞╟╠╡╢╣╤╥╦╧╨╩╪╫╬⌞⌟⌜⌝⌊⌋⌉⌈⌋₯ͰͱͲͳʹ͵Ͷͷͺͻͼͽ;΄΅Ⓐⓐ⒜AaÂÃǍǎȂȃÀÁĀāĄąǞȀȁÅǺǻÄäǟǠǡâáåãàȦȧȺÅⱥÆæǼǢǣⱯⱭª℀⅍℁Ⓑⓑ⒝BbƁɃƀƃƂƄƅℬⒸⓒ⒞CcĆćĈĉĊċČčÇçƇƈȻȼℂ℃ℭƆ℅℆℄Ⓓⓓ⒟DdĎďƊƋƌƉĐđȡⅅⅆǱǲǳǄǅǆȸⒺⓔ⒠EeĒēĔĕĖėĘęĚěÈèÉéÊêËëȄȅȨȩȆȇƎⱸɆℇℯ℮ƐℰƏǝⱻɇⒻⓕ⒡FfƑƒℲⅎℱ℻Ⓖⓖ⒢GgƓĜĝĞğĠġĢģǤǥǦǧǴℊ⅁ǵⒽⓗ⒣HhĤĥȞȟĦħⱧⱨℍǶℏℎℋℌⒾⓘ⒤IiĲĳìíîïÌÍÎÏĨĩĪīĬĭĮįıƗƚǏǐⅈⅉℹℑℐⒿⓙ⒥JjĴĵȷⱼɈɉǰⓀⓚ⒦KkĶķƘƙǨǩⱩⱪĸⓁⓛ⒧LlĹĺĻļĽİľĿŀŁłȽⱠⱡⱢℒǇǈǉ⅃⅂ℓȉȈȊȋⓂⓜ⒨MmⱮƩƜℳⓃⓝ⒩NnŃńŅņŇňǸǹŊƝñŉÑȠƞŋǊǋǌȵℕ№OoȪȫȬȭȮȯȰȱǪǫǬǭƠơŌōŎŏŐőÒÓÔÕÖǑȌȍȎȏŒœØǾǽǿℴ⍥⍤Ⓞⓞ⒪òóôõöǒøⓅⓟ⒫℗PpƤƥⱣℙǷ℘Ⓠⓠ⒬QqɊɋℚ℺ȹⓇⓡ⒭RrŔŕŖŗŘřȐȑȒȓɍɌƦⱤ℞ℜℛ℟ℝⓈⓢ⒮SsŚśŜŝŞşŠšȘșȿƧƨß℠Ⓣⓣ⒯TtŢţŤťŦŧƬƮȚȾƫƭțⱦȶ℡™Ⓤⓤ⒰UuỮỰựŨũŪūŬŭŮůŰűǙǚǗǘǛǜŲųǓǔȔȕÛûȖȗÙùÜüƯúɄưƲƱⓋⓥ⒱VvɅ℣ⱱⱴⱽⓌⓦ⒲WwŴŵⱲⱳⓍⓧ⒳XxℵⓎⓨ⒴yYŶŷƳƴŸÿÝýɎɏȲƔ⅄ȳℽⓏⓩ⒵ZzŹźŻżŽžȤȥⱫⱬƵƶɀℨℤ⟀⟁⟂⟃⟄⟇⟈⟉⟊⟐⟑⟒⟓⟔⟕⟖⟗⟘⟙⟚⟛⟜⟝⟞⟟⟠⟡⟢⟣⟤⟥⟦⟧⟨⟩⟪⟫⦀⦁⦂⦃⦄⦅⦆⦇⦈⦉⦊⦋⦌⦍⦎⦏⦐⦑⦒⦓⦔⦕⦖⦗⦘⦙⦚⦛⦜⦝⦞⦟⦠⦡⦢⦣⦤⦥⦦⦧⦨⦩⦪⦫⦬⦭⦮⦯⦰⦱⦲⦳⦴⦵⦶⦷⦸⦹⦺⦻⦼⦽⦾⦿⧀⧁⧂⧃⧄⧅⧆⧇⧈⧉⧊⧋⧌⧍⧎⧏⧐⧑⧒⧓⧔⧕⧖⧗⧘⧙⧚⧛⧜⧝⧞⧟⧡⧢⧣⧤⧥⧦⧧⧨⧩⧪⧫⧬⧭⧮⧯⧰⧱⧲⧳⧴⧵⧶⧷⧸⧹⧺⧻⧼⧽⧾⧿∀∁∂∃∄∅∆∇∈∉∊∋∌∍∎∏∐∑−∓∔∕∖∗∘∙√∛∜∝∞∟∠∡∢∣∤∥∦∧∨∩∪∫∬∭∮∯∰∱∲∳∴∵∶∷∸∹∺∻∼∽∾∿≀≁≂≃≄≅≆≇≈≉≊≋≌≍≎≏≐≑≒≓≔≕≖≗≘≙≚≛≜≝≞≟≠≡≢≣≤≥≦≧≨≩≪≫≬≭≮≯≰≱≲≳≴≵≶≷≸≹≺≻≼≽≾≿⊀⊁⊂⊃⊄⊅⊆⊇⊈⊉⊊⊋⊌⊍⊎⊏⊐⊑⊒⊓⊔⊕⊖⊗⊘⊙⊚⊛⊜⊝⊞⊟⊠⊡⊢⊣⊤⊥⊦⊧⊨⊩⊪⊫⊬⊭⊮⊯⊰⊱⊲⊳⊴⊵⊶⊷⊸⊹⊺⊻⊼⊽⊾⊿⋀⋁⋂⋃⋄⋅⋆⋇⋈⋉⋊⋋⋌⋍⋎⋏⋐⋑⋒⋓⋔⋕⋖⋗⋘⋙⋚⋛⋜⋝⋞⋟⋠⋡⋢⋣⋤⋥⋦⋧⋨⋩⋪⋫⋬⋭⋮⋯⋰⋱⋲⋳⋴⋵⋶⋷⋸⋹⋺⋻⋼⋽⋾⋿✕✖✚◀▶❝❞★☆☼☂☺☹✄✈✌✎♪♫☀☁☔⚡❆☽☾✆✔☯☮☠⚑☬✄✏♰✡✰✺⚢⚣♕♛♚♬ⓐⓑⓒⓓ↺↻⇖⇗⇘⇙⟵⟷⟶⤴⤵⤶⤷➫➬€₤＄₩₪⟁⟐◆⎔░▢⊡▩⟡◎◵⊗❖ΩβΦΣΞ⟁⦻⧉⧭⧴∞≌⊕⋍⋰⋱✖⓵⓶⓷⓸⓹⓺⓻⓼⓽⓾ᴕ⸨⸩❪❫⓵⓶⓷⓸⓹⓺⓻⓼⓽⓾⒈⒉⒊⒋⒌⒍⒎⒏⒐⒑⒒⒓⒔⒕⒖⒗⒘⒙⒚⒛⓪①②③④⑤⑥⑦⑧⑨⑩➀➁➂➃➄➅➆➇➈➉⑪⑫⑬⑭⑮⑯⑰⑱⑲⑳⓿❶❷❸❹❺❻❼❽❾❿➊➋➌➍➎➏➐➑➒➓⓫⓬⓭⓮⓯⓰⓱⓲⓳⓴⑴⑵⑶⑷⑸⑹⑺⑻⑼⑽⑾⑿⒀⒁⒂⒃⒄⒅⒆⒇‘’‛‚“”„‟«»‹›Ꞌ❛❜❝❞<>@‧¨․:⁚⁝⁞‥…⁖⸪⸬⸫⸭⁛⁘⁙⁏;⦂⁃-–⎯—―_⁓⸛⸞⸟ⸯ¬/⁄⁄|⎜¦‖‗†‡·•⸰°‣⁒%‰‱&⅋§÷+±=꞊′″‴⁗‵‶‷‸*⁑⁎⁕※⁜⁂!‼¡?¿⸮⁇⁉⁈‽⸘¼½¾²³©®™℠℻℅℁⅍℄¶⁋❡⁌⁍⸖⸗⸚⸓()[]{}⸨⸩❨❩❪❫⸦⸧❬❭❮❯❰❱❴❵❲❳⦗⦘⁅⁆〈〉⏜⏝⏞⏟⸡⸠⸢⸣⸤⸥⎡⎤⎣⎦⎨⎬⌠⌡⎛⎠⎝⎞⁀⁔‿⁐‾⎟⎢⎥⎪⎮⎧⎫⎩⎭⎰⎱✈☀☼☁☂☔⚡❄❅❆☃☉☄★☆☽☾⌛⌚☇☈⌂⌁⏧✆☎☏☑✓✔⎷⍻✖✗✘☒✕☓☕♿✌☚☛☜☝☞☟☹☺☻☯⚘☮✝⚰⚱⚠☠☢⚔⚓⎈⚒⚑⚐☡❂⚕⚖⚗✇☣⚙☤⚚⚛⚜☥☦☧☨☩†☪☫☬☭✁✂✃✄✍✎✏✐✑✒✉✙✚✜✛♰♱✞✟✠✡☸✢✣✤✥✦✧✩✪✫✬✭✮✯✰✲✱✳✴✵✶✷✸✹✺✻✼✽✾❀✿❁❃❇❈❉❊❋⁕☘❦❧☙❢❣♀♂⚲⚢⚣⚤⚥⚦⚧⚨⚩☿♁⚯♔♕♖♗♘♙♚♛♜♝♞♟☖☗♠♣♦♥❤❥♡♢♤♧⚀⚁⚂⚃⚄⚅⚇⚆⚈⚉♨♩♪♫♬♭♮♯⌨⏏⎗⎘⎙⎚⌥⎇⌘⌦⌫⌧♲♳♴♵♶♷♸♹♺♻♼♽⁌⁍⎌⌇⌲⍝⍟⍣⍤⍥⍨⍩⎋♃♄♅♆♇♈♉♊♋♌♍♎♏♐♑♒♓⏚⏛|\r\n";

        private void button1_Click(object sender, EventArgs e)
        {
            string GetColor(Color c)
            {
                string str = "";
                str += c.R.ToString("x8").Substring(6, 2);
                str += c.G.ToString("x8").Substring(6, 2);
                str += c.B.ToString("x8").Substring(6, 2);
                return str;
            }

            richTextBox2.Text = "";
            string replaceString = "";
            for (int i = 0; i < richTextBox1.Text.Length; i++)
            {
                Color ci = GetCharColor(i);
                string c = GetChar(i).ToString();

                richTextBox1.Select(i, 1);
                if (richTextBox1.SelectionProtected)
                {
                    if (c == "{")
                        replaceString += "[i/s";
                    if (c == "1" || c == "2" || c == "3" || c == "4" || c == "5" || c == "6" || c == "7" || c == "8" || c == "9" || c == "0")
                        replaceString += c;
                    if (c == ",")
                        replaceString += ":";
                    if (c == "}")
                        replaceString += "]";

                    richTextBox1.SelectionLength = 0;
                    continue;
                }

                richTextBox1.SelectionLength = 0;

                string end = "]";
                string start = $"[c/{GetColor(ci)}:";
                if (GetColor(ci) != "ffffff")
                {
                    if (i != 0)
                        if (ci == GetCharColor(i - 1))
                            replaceString += "";
                        else
                            replaceString += start;
                    else
                        replaceString += start;

                    replaceString += c;

                    if (ci == GetCharColor(i + 1))
                        replaceString += "";
                    else
                        replaceString += end;

                    if (i == richTextBox1.Text.Length - 1)
                        replaceString += end;
                }
                else
                    replaceString += c;
            }
            richTextBox2.Text += $"{replaceString}";
        }

        private void _SetSelectedColor(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.SelectionColor = ((Button)sender).BackColor;
                richTextBox1.SelectionLength = 0;
                richTextBox1.SelectionColor = Color.Black;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            DialogResult dialogResult = colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                button2.BackColor = colorDialog.Color;
            }
        }

        string prev;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label11.Visible = richTextBox1.Text.Contains("[") || richTextBox1.Text.Contains("]");

            if (prev != richTextBox1.Text || richTextBox1.Text.Length < 1)
            {
                richTextBox1.SelectionColor = Color.White;
                richTextBox1.SelectionFont = richTextBox1.Font;
            }
            prev = richTextBox1.Text;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Images |*.bmp;*.jpg;*.png;*.gif;*.ico";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Bitmap img = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                Clipboard.SetImage(img);

                richTextBox1.Paste(DataFormats.GetFormat(DataFormats.Bitmap));
            }
            richTextBox1.Focus();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text.Length > 0)
                Clipboard.SetText(richTextBox2.Text);
        }

        private void button63_Click(object sender, EventArgs e)
        {

            //string Text = "[34 masterbaits]";
            //
            //string str = "";
            //str += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft Himalaya;}}";
            //str += "{\\colortbl ;\\red255\\green255\\blue255;}";
            //str += "\\uc1";
            //str += "\\pard\\cf1\\b\\f0\\fs24 ";
            //str += Text;
            //str += "}";
            //richTextBox1.SelectedRtf = str;
            //richTextBox1.SelectionLength = 0;

        }

        private void button64_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            string str = $"{{#{customNumaricUpDown1.Value},Id:{customNumaricUpDown2.Value}}}";

            richTextBox1.SelectedText = str;
            richTextBox1.Select(richTextBox1.SelectionStart - str.Length, str.Length);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionProtected = true;
            richTextBox1.SelectionLength = 0;

        }

        private void richTextBox1_Protected(object sender, EventArgs e)
        {
            List<int> p = new List<int>();
            RichTextBox richTextBox = richTextBox1;
            for (int i = 0; i < richTextBox.Text.Length; i++)
            {
                richTextBox.Select(i, 1);
                if (richTextBox.SelectionProtected)
                    p.Add(i);
            }
            richTextBox.Select(p[0], p.Count + 1);
            richTextBox.SelectedText = "";
            richTextBox.SelectionLength = 0;
            richTextBox1 = richTextBox;
            //Change Color

            //Type add, start
            //Type add, start

            //Type add, in
            //Type sub, in
            //Dealtea, in
            //Backspace, in

            //Dealtea
            //Backspace

            //Highlte, Del
            //Highlte, Backspace
            //Highlte, type

            //Highlte some, Del
            //Highlte some, Backspace
            //Highlte some, type

            //Highlte All, Del
            //Highlte All, Backspace
            //Highlte All, type
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            string str = $"{richTextBox1.SelectionStart},{richTextBox1.SelectionLength},{richTextBox1.SelectionProtected}";

            richTextBox4.Text = str;

        }

        private void button65_Click(object sender, EventArgs e)
        {
            RichTextBox richTextBox = richTextBox1;
            for (int i = 0; i < richTextBox.Text.Length; i++)
            {
                richTextBox.Select(i, 0);
                //if (richTextBox.SelectionProtected)
                //richTextBox3.Text += i + ",";
            }
            //richTextBox3.Text += "\n";
            richTextBox.SelectionLength = 0;
        }

        private void customNumaricUpDown1_ValueChanged(global::System.Object sender, global::System.EventArgs e)
        {

        }

        private void button66_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.Show();
        }

        private void customNumaricUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}