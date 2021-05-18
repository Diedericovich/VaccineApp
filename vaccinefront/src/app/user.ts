import {Appointment} from './appointment'

export interface User{
    id: number;
    email: string;
    firstName: string;
    surName: string;
    address: string;
    birthDate: Date;
    appointments: Appointment[];
}