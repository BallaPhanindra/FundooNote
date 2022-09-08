﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.User;
using RepositoryLayer.Service.Entities;

namespace BusinessLayer.Interface
{
    public interface INoteBL
    {
        void AddNote(NoteModel noteModel, int UserId);
        public void UpdateNote(UpdateNoteModel updateNoteModel, int UserId, int NoteId);
        public bool DeleteNote(int UserId, int NoteId);
        public Note GetNote(int UserId, int NoteId);
        public List<Note> GetAllNotes(int UserId);
        public List<NoteResponseModel> GetAllNotesUsingJoin(int UserId);
        Task<bool> ArchieveNote(int UserId, int NoteId);
    }
}