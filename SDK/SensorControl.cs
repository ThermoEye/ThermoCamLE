using System;
using System.Windows.Forms;

namespace ThermoCamSDK
{
    public partial class MainForm
    {
        #region Sensor Control
        private void button_SensorControl_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && mCamera != null && mCamera.IsOpen)
            {
                switch (btn.Name)
                {
                    case "button_GetFluxParameters_160E":
                        if (mCamera.Control.GetFluxParameters(out double sceneEmissivity, out double backgroundTemperature,
                                                              out double windowTransmission, out double windowTemperature,
                                                              out double atmosphericTransmission, out double atmosphericTemperature,
                                                              out double windowReflection, out double windowReflectedTemperature))
                        {
                            numericUpDown_FluxParam160E_SceneEmissivity.Value = Convert.ToDecimal(sceneEmissivity);
                            numericUpDown_FluxParam160E_BackgroundTemperature.Value = Convert.ToDecimal(backgroundTemperature);
                            numericUpDown_FluxParam160E_WindowTransmission.Value = Convert.ToDecimal(windowTransmission);
                            numericUpDown_FluxParam160E_WindowTemperature.Value = Convert.ToDecimal(windowTemperature);
                            numericUpDown_FluxParam160E_AtmosphericTransmission.Value = Convert.ToDecimal(atmosphericTransmission);
                            numericUpDown_FluxParam160E_AtmosphericTemperature.Value = Convert.ToDecimal(atmosphericTemperature);
                            numericUpDown_FluxParam160E_WindowReflection.Value = Convert.ToDecimal(windowReflection);
                            numericUpDown_FluxParam160E_WindowReflectedTemperature.Value = Convert.ToDecimal(windowReflectedTemperature);

                            numericUpDown_FluxParam160E_SceneEmissivity.Enabled = true;
                            numericUpDown_FluxParam160E_BackgroundTemperature.Enabled = true;
                            numericUpDown_FluxParam160E_WindowTransmission.Enabled = true;
                            numericUpDown_FluxParam160E_WindowTemperature.Enabled = true;
                            numericUpDown_FluxParam160E_AtmosphericTransmission.Enabled = true;
                            numericUpDown_FluxParam160E_AtmosphericTemperature.Enabled = true;
                            numericUpDown_FluxParam160E_WindowReflection.Enabled = true;
                            numericUpDown_FluxParam160E_WindowReflectedTemperature.Enabled = true;
                            textBox_FluxParam160E_SceneEmissivityRange.Enabled = true;
                            textBox_FluxParam160E_BackgroundTemperatureRange.Enabled = true;
                            textBox_FluxParam160E_WindowTransmissionRange.Enabled = true;
                            textBox_FluxParam160E_WindowTemperatureRange.Enabled = true;
                            textBox_FluxParam160E_AtmosphericTransmissionRange.Enabled = true;
                            textBox_FluxParam160E_AtmosphericTemperatureRange.Enabled = true;
                            textBox_FluxParam160E_WindowReflectionRange.Enabled = true;
                            textBox_FluxParam160E_WindowReflectedTemperatureRange.Enabled = true;
                            button_SetFluxParameters_160E.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Fail to get Flux Parameters.", "Flux Parameters", MessageBoxButtons.OK);
                        }

                        break;

                    case "button_SetFluxParameters_160E":
                        double sceneEmissivitySet = Convert.ToDouble(numericUpDown_FluxParam160E_SceneEmissivity.Value);
                        double backgroundTemperatureSet = Convert.ToDouble(numericUpDown_FluxParam160E_BackgroundTemperature.Value);
                        double windowTransmissionSet = Convert.ToDouble(numericUpDown_FluxParam160E_WindowTransmission.Value);
                        double windowTemperatureSet = Convert.ToDouble(numericUpDown_FluxParam160E_WindowTemperature.Value);
                        double atmosphericTransmissionSet = Convert.ToDouble(numericUpDown_FluxParam160E_AtmosphericTransmission.Value);
                        double atmosphericTemperatureSet = Convert.ToDouble(numericUpDown_FluxParam160E_AtmosphericTemperature.Value);
                        double windowReflectionSet = Convert.ToDouble(numericUpDown_FluxParam160E_WindowReflection.Value);
                        double windowReflectedTemperatureSet = Convert.ToDouble(numericUpDown_FluxParam160E_WindowReflectedTemperature.Value);

                        if (mCamera.Control.SetFluxParameters(sceneEmissivitySet, backgroundTemperatureSet,
                                                              windowTransmissionSet, windowTemperatureSet,
                                                              atmosphericTransmissionSet, atmosphericTemperatureSet,
                                                              windowReflectionSet, windowReflectedTemperatureSet))
                        {
                            MessageBox.Show("Succes to set Flux Parameters.", "Flux Parameters", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Fail to set Flux Parameters.", "Flux Parameters", MessageBoxButtons.OK);
                        }
                        
                        break;

                    case "button_SetDefaultFluxParameters_160E":
                        if (mCamera.Control.SetDefaultFluxParameters(out double sceneEmissivityDef, out double backgroundTemperatureDef,
                                                                     out double windowTransmissionDef, out double windowTemperatureDef,
                                                                     out double atmosphericTransmissionDef, out double atmosphericTemperatureDef,
                                                                     out double windowReflectionDef, out double windowReflectedTemperatureDef))
                        {
                            numericUpDown_FluxParam160E_SceneEmissivity.Value = Convert.ToDecimal(sceneEmissivityDef);
                            numericUpDown_FluxParam160E_BackgroundTemperature.Value = Convert.ToDecimal(backgroundTemperatureDef);
                            numericUpDown_FluxParam160E_WindowTransmission.Value = Convert.ToDecimal(windowTransmissionDef);
                            numericUpDown_FluxParam160E_WindowTemperature.Value = Convert.ToDecimal(windowTemperatureDef);
                            numericUpDown_FluxParam160E_AtmosphericTransmission.Value = Convert.ToDecimal(atmosphericTransmissionDef);
                            numericUpDown_FluxParam160E_AtmosphericTemperature.Value = Convert.ToDecimal(atmosphericTemperatureDef);
                            numericUpDown_FluxParam160E_WindowReflection.Value = Convert.ToDecimal(windowReflectionDef);
                            numericUpDown_FluxParam160E_WindowReflectedTemperature.Value = Convert.ToDecimal(windowReflectedTemperatureDef);

                            numericUpDown_FluxParam160E_SceneEmissivity.Enabled = true;
                            numericUpDown_FluxParam160E_BackgroundTemperature.Enabled = true;
                            numericUpDown_FluxParam160E_WindowTransmission.Enabled = true;
                            numericUpDown_FluxParam160E_WindowTemperature.Enabled = true;
                            numericUpDown_FluxParam160E_AtmosphericTransmission.Enabled = true;
                            numericUpDown_FluxParam160E_AtmosphericTemperature.Enabled = true;
                            numericUpDown_FluxParam160E_WindowReflection.Enabled = true;
                            numericUpDown_FluxParam160E_WindowReflectedTemperature.Enabled = true;
                            textBox_FluxParam160E_SceneEmissivityRange.Enabled = true;
                            textBox_FluxParam160E_BackgroundTemperatureRange.Enabled = true;
                            textBox_FluxParam160E_WindowTransmissionRange.Enabled = true;
                            textBox_FluxParam160E_WindowTemperatureRange.Enabled = true;
                            textBox_FluxParam160E_AtmosphericTransmissionRange.Enabled = true;
                            textBox_FluxParam160E_AtmosphericTemperatureRange.Enabled = true;
                            textBox_FluxParam160E_WindowReflectionRange.Enabled = true;
                            textBox_FluxParam160E_WindowReflectedTemperatureRange.Enabled = true;
                            button_SetFluxParameters_160E.Enabled = true;

                            MessageBox.Show("Succes to set Factory Default Flux Parameters.", "Flux Parameters", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Fail to set Factory Default Flux Parameters.", "Flux Parameters", MessageBoxButtons.OK);
                        }

                        break;

                    case "button_GetFluxParameters_256E":
                        if (mCamera.Control.GetFluxParameters(out double emissivity, out double atmosphericTransmittance,
                                                              out double ambientAtmosphericTemperature, out double ambientReflectionTemperature,
                                                              out double distance))
                        {
                            numericUpDown_FluxParam256E_Emissivity.Value = Convert.ToDecimal(emissivity);
                            numericUpDown_FluxParam256E_AtmosphericTransmittance.Value = Convert.ToDecimal(atmosphericTransmittance);
                            numericUpDown_FluxParam256E_AtmosphericTemperature.Value = Convert.ToDecimal(ambientAtmosphericTemperature);
                            numericUpDown_FluxParam256E_AmbientReflectionTemperature.Value = Convert.ToDecimal(ambientReflectionTemperature);
                            numericUpDown_FluxParam256E_Distance.Value = Convert.ToDecimal(distance);

                            numericUpDown_FluxParam256E_Emissivity.Enabled = true;
                            numericUpDown_FluxParam256E_AtmosphericTransmittance.Enabled = true;
                            numericUpDown_FluxParam256E_AtmosphericTemperature.Enabled = true;
                            numericUpDown_FluxParam256E_AmbientReflectionTemperature.Enabled = true;
                            numericUpDown_FluxParam256E_Distance.Enabled = true;
                            textBox_FluxParam256E_EmissivityRange.Enabled = true;
                            textBox_FluxParam256E_AtmosphericTransmittanceRange.Enabled = true;
                            textBox_FluxParam256E_AtmosphericTemperatureRange.Enabled = true;
                            textBox_FluxParam256E_AmbientReflectionTemperatureRange.Enabled = true;
                            textBox_FluxParam256E_DistanceRange.Enabled = true;
                            button_SetFluxParameters_256E.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Fail to get Flux Parameters.", "Flux Parameters", MessageBoxButtons.OK);
                        }

                        break;

                    case "button_SetFluxParameters_256E":
                        double emissivitySet = Convert.ToDouble(numericUpDown_FluxParam256E_Emissivity.Value);
                        double atmosphericTransmittanceSet = Convert.ToDouble(numericUpDown_FluxParam256E_AtmosphericTransmittance.Value);
                        double ambientAtmosphericTemperatureSet = Convert.ToDouble(numericUpDown_FluxParam256E_AtmosphericTemperature.Value);
                        double ambientReflectionTemperatureSet = Convert.ToDouble(numericUpDown_FluxParam256E_AmbientReflectionTemperature.Value);
                        double distanceSet = Convert.ToDouble(numericUpDown_FluxParam256E_Distance.Value);

                        if (mCamera.Control.SetFluxParameters(emissivitySet, atmosphericTransmittanceSet,
                                                              ambientAtmosphericTemperatureSet, ambientReflectionTemperatureSet,
                                                              distanceSet))
                        {
                            MessageBox.Show("Succes to set Flux Parameters.", "Flux Parameters", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Fail to set Flux Parameters.", "Flux Parameters", MessageBoxButtons.OK);
                        }

                        break;

                    case "button_SetDefaultFluxParameters_256E":
                        button_SetDefaultFluxParameters_256E.Text = "Wait...";
                        button_SetDefaultFluxParameters_256E.Enabled = false;

                        if (mCamera.Control.SetDefaultFluxParameters(out double emissivityDef, out double atmosphericTransmittanceDef,
                                                                     out double ambientAtmosphericTemperatureDef, out double ambientReflectionTemperatureDef,
                                                                     out double distanceDef))
                        {
                            numericUpDown_FluxParam256E_Emissivity.Value = Convert.ToDecimal(emissivityDef);
                            numericUpDown_FluxParam256E_AtmosphericTransmittance.Value = Convert.ToDecimal(atmosphericTransmittanceDef);
                            numericUpDown_FluxParam256E_AtmosphericTemperature.Value = Convert.ToDecimal(ambientAtmosphericTemperatureDef);
                            numericUpDown_FluxParam256E_AmbientReflectionTemperature.Value = Convert.ToDecimal(ambientReflectionTemperatureDef);
                            numericUpDown_FluxParam256E_Distance.Value = Convert.ToDecimal(distanceDef);

                            numericUpDown_FluxParam256E_Emissivity.Enabled = true;
                            numericUpDown_FluxParam256E_AtmosphericTransmittance.Enabled = true;
                            numericUpDown_FluxParam256E_AtmosphericTemperature.Enabled = true;
                            numericUpDown_FluxParam256E_AmbientReflectionTemperature.Enabled = true;
                            numericUpDown_FluxParam256E_Distance.Enabled = true;
                            textBox_FluxParam256E_EmissivityRange.Enabled = true;
                            textBox_FluxParam256E_AtmosphericTransmittanceRange.Enabled = true;
                            textBox_FluxParam256E_AtmosphericTemperatureRange.Enabled = true;
                            textBox_FluxParam256E_AmbientReflectionTemperatureRange.Enabled = true;
                            textBox_FluxParam256E_DistanceRange.Enabled = true;
                            button_SetFluxParameters_256E.Enabled = true;

                            MessageBox.Show("Succes to set Factory Default Flux Parameters.", "Flux Parameters", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Fail to set Factory Default Flux Parameters.", "Flux Parameters", MessageBoxButtons.OK);
                        }

                        button_SetDefaultFluxParameters_256E.Text = "Set to Factory Default";
                        button_SetDefaultFluxParameters_256E.Enabled = true;

                        break;

                    case "button_GetFlatFieldCorrectionMode":
                        int ffcMode = mCamera.Control.GetFlatFieldCorrectionMode();

                        if (ffcMode == 0) // Manual
                        {
                            radioButton_FlatFieldCorrectionManual.Checked = true;
                            radioButton_FlatFieldCorrectionAutomatic.Checked = false;
                        }
                        else if (ffcMode == 1) // Automatic
                        {
                            radioButton_FlatFieldCorrectionManual.Checked = false;
                            radioButton_FlatFieldCorrectionAutomatic.Checked = true;
                        }
                        else
                        {
                            radioButton_FlatFieldCorrectionManual.Checked = false;
                            radioButton_FlatFieldCorrectionAutomatic.Checked = false;

                            MessageBox.Show("Fail to get Flat Field Correction Mode", "Flat Field Correction", MessageBoxButtons.OK);
                        }
                        
                        break;

                    case "button_SetFlatFieldCorrectionMode":
                        int ffcModeSet = -1;

                        if ((radioButton_FlatFieldCorrectionManual.Checked == true) && (radioButton_FlatFieldCorrectionAutomatic.Checked == false))
                            ffcModeSet = 0; // Manual
                        else if ((radioButton_FlatFieldCorrectionManual.Checked == false) && (radioButton_FlatFieldCorrectionAutomatic.Checked == true))
                            ffcModeSet = 1; // Automatic

                        if (ffcModeSet != -1)
                            mCamera.Control.SetFlatFieldCorrectionMode(ffcModeSet);
                        else
                            MessageBox.Show("Fail to set Flat Field Correction Mode", "Flat Field Correction", MessageBoxButtons.OK);
                        
                        break;

                    case "button_RunFlatFieldCorrection":
                        button_RunFlatFieldCorrection.Text = "Wait...";
                        button_RunFlatFieldCorrection.Enabled = false;

                        if (mCamera.Control.RunFlatFieldCorrection())
                        {
                            MessageBox.Show("Success to run Flat Field Correction", "Flat Field Correction", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Fail to run Flat Field Correction", "Flat Field Correction", MessageBoxButtons.OK);
                        }

                        button_RunFlatFieldCorrection.Text = "Run";
                        button_RunFlatFieldCorrection.Enabled = true;
                        
                        break;

                    case "button_GetGainModeState":
                        int gainModeState = mCamera.Control.GetGainModeState();

                        if (gainModeState == 0) // High
                        {
                            radioButton_GainModeStateHigh.Checked = true;
                            radioButton_GainModeStateLow.Checked = false;
                            radioButton_GainModeStateAuto.Checked = false;
                        }
                        else if (gainModeState == 1) // Low
                        {
                            radioButton_GainModeStateHigh.Checked = false;
                            radioButton_GainModeStateLow.Checked = true;
                            radioButton_GainModeStateAuto.Checked = false;
                        }
                        else if (gainModeState == 2) // Auto
                        {
                            radioButton_GainModeStateHigh.Checked = false;
                            radioButton_GainModeStateLow.Checked = false;
                            radioButton_GainModeStateAuto.Checked = true;
                        }
                        else
                        {
                            radioButton_GainModeStateHigh.Checked = false;
                            radioButton_GainModeStateLow.Checked = false;
                            radioButton_GainModeStateAuto.Checked = false;

                            MessageBox.Show("Fail to get Gain Mode State", "Gain Mode", MessageBoxButtons.OK);
                        }

                        break;

                    case "button_SetGainModeState":
                        int gainModeStateSet = -1;

                        button_SetGainModeState.Text = "Wait...";
                        button_SetGainModeState.Enabled = false;

                        if ((radioButton_GainModeStateHigh.Checked == true) && (radioButton_GainModeStateLow.Checked == false) && (radioButton_GainModeStateAuto.Checked == false))
                            gainModeStateSet = 0; // High
                        else if ((radioButton_GainModeStateHigh.Checked == false) && (radioButton_GainModeStateLow.Checked == true) && (radioButton_GainModeStateAuto.Checked == false))
                            gainModeStateSet = 1; // Low
                        else if ((radioButton_GainModeStateHigh.Checked == false) && (radioButton_GainModeStateLow.Checked == false) && (radioButton_GainModeStateAuto.Checked == true))
                            gainModeStateSet = 2; // Auto

                        if ((gainModeStateSet != -1) && mCamera.Control.SetGainModeState(gainModeStateSet))
                        {
                            MessageBox.Show("Success to set Gain Mode State", "Gain Mode", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Fail to set Gain Mode State", "Gain Mode", MessageBoxButtons.OK);
                        }

                        button_SetGainModeState.Text = "Set";
                        button_SetGainModeState.Enabled = true;

                        break;
                }
            }
        }

        private void numericUpDown_FluxParam160E_SceneEmissivity_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void numericUpDown_FluxParam160E_BackgroundTemperature_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void numericUpDown_FluxParam160E_WindowTransmission_ValueChanged(object sender, EventArgs e)
        {
            double windowTransmission = Convert.ToDouble(numericUpDown_FluxParam160E_WindowTransmission.Value);
            double maxWindowReflection = 1.0d - windowTransmission;
            double windowReflection = Convert.ToDouble(numericUpDown_FluxParam160E_WindowReflection.Value);
            if (windowReflection > maxWindowReflection)
                numericUpDown_FluxParam160E_WindowReflection.Value = Convert.ToDecimal(maxWindowReflection);

            textBox_FluxParam160E_WindowReflectionRange.Text = "0.00 ~ " + string.Format("{0:0.00}", maxWindowReflection);

            Refresh();
        }

        private void numericUpDown_FluxParam160E_WindowTemperature_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void numericUpDown_FluxParam160E_AtmosphericTransmission_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void numericUpDown_FluxParam160E_AtmosphericTemperature_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void numericUpDown_FluxParam160E_WindowReflection_ValueChanged(object sender, EventArgs e)
        {
            double windowTransmission = Convert.ToDouble(numericUpDown_FluxParam160E_WindowTransmission.Value);
            double maxWindowReflection = 1.0d - windowTransmission;
            double windowReflection = Convert.ToDouble(numericUpDown_FluxParam160E_WindowReflection.Value);
            if (windowReflection > maxWindowReflection)
                numericUpDown_FluxParam160E_WindowReflection.Value = Convert.ToDecimal(maxWindowReflection);

            textBox_FluxParam160E_WindowReflectionRange.Text = "0.00 ~ " + string.Format("{0:0.00}", maxWindowReflection);

            Refresh();
        }

        private void numericUpDown_FluxParam160E_WindowReflectedTemperature_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void numericUpDown_FluxParam256E_Emissivity_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void numericUpDown_FluxParam256E_AtmosphericTransmittance_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void numericUpDown_FluxParam256E_AtmosphericTemperature_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void numericUpDown_FluxParam256E_ReflectionTemperature_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void numericUpDown_FluxParam256E_Distance_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }
        #endregion
    }
}
