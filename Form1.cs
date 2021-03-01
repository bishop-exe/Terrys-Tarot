using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Terry_sTarotV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Select(0, 0);
        }

        private Bitmap[] GetResourceImages()
        {

            PropertyInfo[] props = typeof(Properties.Resources).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
            var images = props.Where(prop => prop.PropertyType == typeof(Bitmap)).Select(prop => prop.GetValue(null, null) as Bitmap).ToArray();
            return images;
        }
        private void RandomizePicture()
        {
            Bitmap[] images = GetResourceImages();
            if (images == null || images.Length == 0)
            {
                //Nothing to do here...
                return;
            }

            int maxValue = images.Length;
            DateTime moment = DateTime.Today;
            
            //Random r = new Random(moment.Day);
            string name_seed = Environment.UserName.ToString();
            int numVal = Convert.ToInt32(name_seed[0]);
            Random r = new Random(moment.Day + numVal);
            bool rotate = false;
            int idx = r.Next(maxValue);
            while (idx > 21)
            {
                idx = r.Next(maxValue);
            }
            this.pictureBox1.Image = images[idx];
            if (r.Next(0, 2) == 0) {
                Console.WriteLine("Rotate");
                rotate = true;
            }
            switch (idx)
            {
                case 0:
                    if (!rotate) {
                        textBox1.Text = "0.THE FOOL--Folly, mania, extravagance, intoxication, delirium, frenzy, bewrayment. ";
                    }
                    else
                        textBox1.Text = "0.THE FOOL--Reversed: Negligence, absence, distribution, carelessness, apathy, nullity, vanity.";
                    break;
                case 1:
                    if (!rotate)
                    {
                        textBox1.Text = "1.MAGICIAN--Skill, diplomacy, address, subtlety, pain, loss, disaster, snares of enemies; self-confidence, will; [it signifies] the Querent, if male.";
                    }
                    else
                        textBox1.Text = "1.MAGICIAN--Reversed: Physician, mental disease, disgrace, disquiet.";
                    break;
                case 2:
                    if (!rotate)
                    {
                        textBox1.Text = "10.THE WHEEL--Destiny, fortune, success, elevation, luck, felicity.";
                    }
                    else
                        textBox1.Text = "10.THE WHEEL--Reversed:  Increase, abundance, superfluity.";
                    break;
                case 3:
                    if (!rotate)
                    {
                        textBox1.Text = "11.JUSTICE--Equity, rightness, probity, executive; triumph of the deserving side in law.";
                    }
                    else
                        textBox1.Text = "11.JUSTICE--Reversed: Law in all its departments, legal complications, bigotry, bias, excessive severity.";
                    break;
                case 4:
                    if (!rotate)
                    {
                        textBox1.Text = "12. THE HANGED MAN --Wisdom, circumspection, discernment, trials, sacrifice, intuition, divination, prophecy.";
                    }
                    else
                        textBox1.Text = "12. THE HANGED MAN --Reversed: Selfishness, the crowd, body politic.";
                    break;
                case 5:
                    if (!rotate)
                    {
                        textBox1.Text = "13.DEATH--End, mortality, destruction, corruption; also, for a man, the loss of a benefactor; for a woman, many contrarieties; for a maid, failure of marriage projects";
                    }
                    else
                        textBox1.Text = "13.DEATH--Reversed: Inertia, sleep, lethargy, petrifaction, somnambulism; hope destroyed.";
                    break;
                case 6:
                    if (!rotate)
                    {
                        textBox1.Text = "14.TEMPERANCE--Economy, moderation, frugality, management, accommodation. ";
                    }
                    else
                        textBox1.Text = "14.TEMPERANCE--Reversed: Things connected with churches, religions, sects, the priesthood, sometimes even the priest who will marry Querent; also disunion, unfortunate combinations, competing interests.";
                    break;
                case 7:
                    if (!rotate)
                    {
                        textBox1.Text = "15.THE DEVIL--Ravage, violence, vehemence, extraordinary efforts, force, fatality; that which is predestined but is not for this reason evil. ";
                    }
                    else
                        textBox1.Text = "15.THE DEVIL--Reversed: Evil fatality, weakness, pettiness, blindness.";
                    break;
                case 8:
                    if (!rotate)
                    {
                        textBox1.Text = "16. THE TOWER-- Misery, distress, indigence, adversity, calamity, disgrace, deception, ruin. It is a card in particular of unforeseen catastrophe.";
                    }
                    else
                        textBox1.Text = "16. THE TOWER--Reversed: Negligence, absence, distribution, carelessness, apathy, nullity, vanity.";
                    break;
                case 9:
                    if (!rotate)
                    {
                        textBox1.Text = "17.THE STAR--Loss, theft, privation, abandonment; another reading says--hope bright prospects,";
                    }
                    else
                        textBox1.Text = "17.THE STAR--Reversed: Arrogance, haughtiness, impotence.";
                    break;
                case 10:
                    if (!rotate)
                    {
                        textBox1.Text = "18.THE MOON--Hidden enemies, danger, calumny, darkness, terror, deception, occult forces, error. ";
                    }
                    else
                        textBox1.Text = "18.THE MOON--Reversed: Instability, inconstancy, silence, lesser degrees of deception and error.";
                    break;
                case 11:
                    if (!rotate)
                    {
                        textBox1.Text = "19.THE SUN--Enlightment, Joy, Marriage, Material happiness, Success, Vitality.";
                    }
                    else
                        textBox1.Text = "19.THE SUN--Reversed: False impressions, Lack of clarity, Low Vitality, Sadness";
                    break;
                case 12:
                    if (!rotate)
                    {
                        textBox1.Text = "2.THE HIGH PRIESTESS--Secrets, mystery, the future as yet unrevealed; the woman who interests the Querent, if male; the Querent herself, if female; silence, tenacity; mystery, wisdom, science.";
                    }
                    else
                        textBox1.Text = "2.THE HIGH PRIESTESS--Reversed: Passion, moral or physical ardor, conceit, surface knowledge.";
                    break;
                case 13:
                    if (!rotate)
                    {
                        textBox1.Text = "20.JUDGEMENT--Awakening, Decision making, Redemption, Reincarnation, Renewal, Transition.";
                    }
                    else
                        textBox1.Text = "20.JUDGEMENT--Reversed: Poor logic, Poor or hasty judgement, Self-doubt, Stagnation.";
                    break;
                case 14:
                    if (!rotate)
                    {
                        textBox1.Text = "21.THE WORLD—-Assured success, recompense, voyage, route, emigration, flight, change of place.";
                    }
                    else
                        textBox1.Text = "21.THE WORLD—-Reversed: Inertia, fixity, stagnation, permanence.";
                    break;
                case 15:
                    if (!rotate)
                    {
                        textBox1.Text = "3. THE EMPRESS--Fruitfulness, action, initiative, length of days; the unknown, clandestine; also difficulty, doubt, ignorance.";
                    }
                    else
                        textBox1.Text = "3. THE EMPRESS--Reversed: Light, truth, the unraveling of involved matters, public rejoicings; according to another reading, vacillation.";
                    break;
                case 16:
                    if (!rotate)
                    {
                        textBox1.Text = "4. THE EMPEROR--Stability, power, protection, realization; a great person; aid, reason, conviction also authority and will";
                    }
                    else
                        textBox1.Text = "4. THE EMPEROR-- Reversed: Benevolence, compassion, credit; also confusion to enemies, obstruction, immaturity. ";
                    break;
                case 17:
                    if (!rotate)
                    {
                        textBox1.Text = "5. THE HIEROPHANT--Marriage, alliance, captivity, servitude; by another account, mercy, and goodness; inspiration; the man to whom the Querent has recourse.";
                    }
                    else
                        textBox1.Text = "5. THE HIEROPHANT--Reversed: Society, good understanding, concord, over kindness, weakness.";
                    break;
                case 18:
                    if (!rotate)
                    {
                        textBox1.Text = "5. THE LOVERS--Attraction, love, beauty, trials overcome.";
                    }
                    else
                        textBox1.Text = "5. THE LOVERS--Reversed: Failure, foolish designs. Another account speaks of marriage frustrated and contrarieties of all kinds.";
                    break;
                case 19:
                    if (!rotate)
                    {
                        textBox1.Text = "7. THE CHARIOT--Succour, providence; also war, triumph, presumption, vengeance, trouble.";
                    }
                    else
                        textBox1.Text = "7. THE CHARIOT--Reversed: Riot, quarrel, dispute, litigation, defeat.";
                    break;
                case 20:
                    if (!rotate)
                    {
                        textBox1.Text = "8. STRENGTH--Power, energy, action, courage, magnanimity; also complete success and honours.";
                    }
                    else
                        textBox1.Text = "8. STRENGTH--Reversed: Despotism, abuse of power, weakness, discord, sometimes even disgrace.";
                    break;
                case 21:
                    if (!rotate)
                    {
                        textBox1.Text = "9.THE HERMIT--Prudence, circumspection; also and especially treason, dissimulation, roguery, corruption. ";
                    }
                    else
                        textBox1.Text = "9.THE HERMIT--Reversed: Concealment, disguise, policy fear, unreasoned caution.";
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
         private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.RandomizePicture();
        }


    }
}
