import {Appointment} from './appointment'

export interface Users{
    id: number;
    email: string;
    firstname: string;
    surname: string;
    adress: string;
    birthDate: Date;
    appointments: Appointment[];
}