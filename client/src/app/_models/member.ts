import { Photo } from './photo';

export interface Member {
    id: number;
    userName: string;
    passwordHash: string;
    passwordSalt: string;
    age: number;
    photoUrl: string;
    knownAs: string;
    dateCreated: Date;
    lastActive: Date;
    gender: string;
    introduction: string;
    lookingFor: string;
    interests: string;
    country: string;
    city: string;
    photos: Photo[];
}
  