#include "mbed.h"
#include "SDFileSystem.h"
 
 
 
//Nucleo L476RG_SDCARD test
 
 
 
/*              SD:                Description             nucleo           PINNR (from top to down of the right-connector-left pins):
                1                   CS                     PB_6   (D10)          9  
                2                   MOSI                   PA_7   (D11)           8
                3                   GND                    GND
                4                   5V                      5V
                5                   SCLK                   PA_5    (D13)          6                  
                6                   -
                7                   MISO                   PA_6    (D12)          7
                8
                
*/
//              MOSI, MISO, SCLK, CS, name
SDFileSystem sd(PA_7, PA_6, PA_5, PB_6, "sd");
 
// adxl335
AnalogIn analog_AccelX(A0); // output of x-axis at analog pin A0
AnalogIn analog_AccelY(A1); // output of y-axis at analog pin A1
AnalogIn analog_AccelZ(A2); // output of z-axis at analog pin A2
 
// temp sensor
AnalogIn LM35(A4);
 
//heart sensor
AnalogIn TCRT1000_Sensor(A5);
Timer timerHeartRate; //Timer
int BPM =0;
 
 
int main() {
  
 
    printf("\nWait for new connection...\n"); 
    
    printf("\nDirectory created\n");
    
    float x=analog_AccelX.read();     
        float y=analog_AccelY.read();
        float z =analog_AccelZ.read();
        //float a=0.833; // where a is expected analog value for acceleration = 2g
        float X= (x-0.500)*6.000;// calculated acceleration based on read values from accelerometer
        float Y= (y-0.500)*6.000;
        float Z =(z-0.500)*6.000;
        //float b=0.167;// where b is expected analog value for acceleration = -2g
  
   // temp LM35
float value; 
      float v1;
       
      value = ((LM35.read()*3312)/10);
        
     v1 = LM35.read(); 
      
    //printf("Temp: %2.2f degree C\r\n", value);
    //printf("Temp: %2.2f degree C\r\n", v1);
   
char CArray[30] = "/sd/myproject/sdtesting99.txt";
 
 
    // Declare a pointer fp of type file. This declaration is needed for communication between the file and program.
    while(1)
    {
       
         x=analog_AccelX.read();     
         y=analog_AccelY.read();
         z =analog_AccelZ.read();
        //float a=0.833; // where a is expected analog value for acceleration = 2g
         X= (x-0.500)*6.000;// calculated acceleration based on read values from accelerometer
        Y= (y-0.500)*6.000;
         Z =(z-0.500)*6.000;
         
         //temperature code
         float value; 
         float v1;
       
        value = ((LM35.read()*3312)/10);
        
        //v1 = LM35.read(); 
//==============================================
        //heart sensor
    int hRbeat = 0;
    int heartRate=0;
    int Pulse = 0;
    timerHeartRate.reset();
    timerHeartRate.start();
    
    printf("Measuring heart beats . . . \n");
    while (timerHeartRate.read() < 10) { //detect heart beat for 10 sec
        Pulse = TCRT1000_Sensor.read();
        printf("%d \r\n",Pulse);
     
       if(Pulse>0.25) { // high beat
            hRbeat =1;
        }
        if((Pulse<0.2)&&(hRbeat==1)) { // low beat
            heartRate += hRbeat;
            hRbeat=0;
            printf("Beat\r\n");
        }
        wait(0.15); 
    }
    BPM = heartRate*3+60;
    
    printf ("\r\nBPM:%d\r\n",(heartRate*6));
    
    // END OF heart sensor code ==========================================
      
    printf("Temp: %2.2f degree C\r\n", value);
        sd.mount();
    FILE *fp = fopen( CArray, "a");
    
    //FILE *fp = fopen(/sd/myproject/sdtesting1.txt, "a");
    
    
    if(fp == NULL) {
        printf("Could not open file for write\n");
    }
    
   
   
    fprintf(fp,"%d,%2.2f,%3.3f,%3.3f,%3.3f \r\n",(heartRate*6),value, X,Y,Z);
    
    
   //this is original code with temp
   // fprintf(fp,"%2.2f,%3.3f,%3.3f,%3.3f\r\n", value,X,Y,Z);
    
    
  
 
        
         fclose(fp); 
        sd.unmount();
         
        
            }
    //printf("Text written to the SD-CARD\n");
}


%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

%  END OF CODE 
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
