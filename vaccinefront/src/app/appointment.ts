import { Status } from './status'
import { VaccinationCenter } from './vaccinationcenter'
import { Vaccine } from './vaccine'
export interface Appointment{
    id: number
    date: Date;
    locaction: VaccinationCenter;
    vaccination:Vaccine;
    status: Status;
}