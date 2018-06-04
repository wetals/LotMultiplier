input double SequenceLot_1    = 1;
input double SequenceLot_2    = 3;
input double SequenceLot_3    = 6;
input double MaxRisk     = 500;

double LiM, sumChecker;

double getLotMultiplier(double MTpoints){
   LiM=1;

   do
     {
      sumChecker = (SequenceLot_1 * LiM * MTpoints) - (SequenceLot_2 * LiM * MTpoints) + (SequenceLot_3 * LiM * MTpoints);
      Print("#################### LiM: ", LiM, ", sumChecker: ", sumChecker);
      LiM+=0.1; 
     }
   while(LiM<20 && sumChecker<MaxRisk && !IsStopped());
   
   return LiM-0.1;
}

double lot = getLotMultiplier(80);
