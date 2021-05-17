import {Appointment} from './appointment'

export interface User{
    id: number;
    email: string;
    firstname: string;
    surname: string;
    adress: string;
    birthDate: Date;
    appointments: Appointment[];
}